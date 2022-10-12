namespace csharp_boolflix.Models;

public class Episode : MediaContent
{
    public int Id { get; set; }
    public int SeasonNumber { get; set; }
    //1...* with TvShow
    public int TvShowId { get; set; }
    public TvShow TvShow { get; set; }
}