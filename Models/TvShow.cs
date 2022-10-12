namespace csharp_boolflix.Models;

public class TvShow : MediaContent
{
    public int SeasonCount { get; set; }
    //1...* with Episode
    public List<Episode> Episodes { get; set; }
    //TODO: *...* with actors, genres
    //*...* with Actor
    public List<Actor> Actors { get; set; }
    //*...* with Genre
    public List<Genre> Genres { get; set; }
}