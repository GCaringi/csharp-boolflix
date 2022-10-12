namespace csharp_boolflix.Models;

public abstract class MediaCommonRelation : MediaStructure
{
    //*...* with Actor
    public List<Actor> Actors { get; set; }
    //*...* with Genre
    public List<Genre> Genres { get; set; }
}