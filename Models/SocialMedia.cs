
namespace MovieMania.Models;

public class SocialMedia
{
    public int id { get; set; }
    public string freebase_mid { get; set; }
    public string freebase_id { get; set; }
    public string imdb_id { get; set; }
    public object tvrage_id { get; set; }
    public object facebook_id { get; set; }
    public object instagram_id { get; set; }
    public object twitter_id { get; set; }
}