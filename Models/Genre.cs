namespace csharp_boolflix.Models;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    //TODO: *...* With Film and TvSeries
    //*...* With Film
    public List<Film> Films { get; set; }
    //*...* With TvSeries
    public List<TvShow> TvSeries { get; set; }
}