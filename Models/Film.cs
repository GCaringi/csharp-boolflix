namespace csharp_boolflix.Models;

public class Film : MediaContent
{
    //TODO: Add relations *...* with actor and genres
    //*...* with Actor
    public List<Actor> Actors { get; set; }
    //*...* with Genre
    public List<Genre> Genres { get; set; }

}