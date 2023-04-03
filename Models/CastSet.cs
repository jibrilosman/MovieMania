
namespace MovieMania.Models;

public class CastSet
{
    public int id { get; set; }
    public List<Cast> cast { get; set; }
    public List<Crew> crew { get; set; }
}