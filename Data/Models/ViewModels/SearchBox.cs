using static DesafioBlazor.Data.SharedContext.Enums;

namespace DesafioBlazor.Data.Models.ViewModels;

public class SearchBox
{
    public SearchBox()
    {
        searchType = SearchType.Code;
        search = string.Empty;
    }
    public SearchType searchType { get; set; }
    public string search { get; set; }
}