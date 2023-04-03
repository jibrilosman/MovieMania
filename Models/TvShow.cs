
namespace MovieMania.Models;

public class TvShow
    {
        public bool adult { get; set; }
        public object backdrop_path { get; set; }
        public List<object> created_by { get; set; }
        public List<object> episode_run_time { get; set; }
        public object first_air_date { get; set; }
        public List<object> genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public bool in_production { get; set; }
        public List<object> languages { get; set; }
        public object last_air_date { get; set; }
        public object last_episode_to_air { get; set; }
        public string name { get; set; }
        public object next_episode_to_air { get; set; }
        public List<object> networks { get; set; }
        public int number_of_episodes { get; set; }
        public int number_of_seasons { get; set; }
        public List<string> origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public object poster_path { get; set; }
        public List<object> production_companies { get; set; }
        public List<object> production_countries { get; set; }
        public List<object> seasons { get; set; }
        public List<object> spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string type { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
    }
