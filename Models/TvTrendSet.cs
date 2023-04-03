namespace MovieMania.Models;

public class TvTrendSet
{
    public int page { get; set; }
    public List<TvTrend> results { get; set; }
    public int total_pages { get; set; }
    public int total_results { get; set; }
}