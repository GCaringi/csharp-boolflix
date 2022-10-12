namespace csharp_boolflix.Models;

public class Actor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    //TODO: Add *...* with Film and TvSeries
    //*...* with Film
    public List<Film> Films { get; set; }
    //*...* with TvSeries
    public List<TvShow> TvShows { get; set; }
}