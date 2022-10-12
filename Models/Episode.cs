using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_boolflix.Models;

public class Episode : MediaStructure
{
    public int Id { get; set; }
    public int SeasonNumber { get; set; }
    //1...* with TvShow
    public int TvShowId { get; set; }
    public TvShow TvShow { get; set; }
}