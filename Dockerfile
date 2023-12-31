ARG ARCH=amd64
ARG VERSION=8.0

FROM mcr.microsoft.com/dotnet/sdk:$VERSION AS build
WORKDIR /app
EXPOSE 80 443

# copy csproj and restore as distinct layers
COPY *.csproj .
RUN dotnet restore

# copy everything else and build app
COPY . .
WORKDIR /app
RUN dotnet publish -c release -o out --no-restore --no-cache /restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:$VERSION
WORKDIR /app
COPY --from=build /app/out .
USER $APP_UID
ENTRYPOINT ["dotnet", "DesafioBlazor.dll"]