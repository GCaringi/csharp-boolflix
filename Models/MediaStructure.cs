namespace csharp_boolflix.Models;

public abstract class MediaStructure
{
    public int Id { get; set; }
    public string Title { get; set; }
    //Duration in minutes
    public int Duration { get; set; }
    public string Description { get; set; }
    public DateTime RelaseDate { get; set; }
    //Every call to view a media content will increment the view count
    public string Views { get; set; }
}