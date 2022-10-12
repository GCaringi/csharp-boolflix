namespace csharp_boolflix.Models;

public class TvShow : MediaCommonRelation
{
    public int SeasonCount { get; set; }
    //1...* with Episode
    public List<Episode> Episodes { get; set; }
}