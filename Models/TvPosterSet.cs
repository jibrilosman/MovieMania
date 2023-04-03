namespace MovieMania.Models;

public class TvPosterSet
    {
        public int page { get; set; }
        public List<TvPoster> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }