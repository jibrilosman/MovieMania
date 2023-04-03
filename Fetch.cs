namespace MovieMania;

public class Fetch {

    public PosterSet? posterSet;
    public Movie? movie;
    public VideoSet? videoSet;
    public CastSet? castSet;
    public TrendSet? trendSet;
    public Actor? actor;
    public ImageSet? imageSet;



    

    public HttpClient req = new HttpClient();
    
    public const string API_KEY = "7775daa1ebc95476e157fa1148866a7e";
    public const string API_PREFIX = "https://api.themoviedb.org/3/";
    public string? Data {get; set;}
    public string? Details {get; set;}
    public string? Videos {get; set;}
    public string? Credits {get; set;}
    public string? Images {get; set;}

    public Fetch(){}


    // begin Actor Details
    public async Task ActorDetails(string id){
        ClearHeaders();


    HttpResponseMessage res = 
        await req.GetAsync(API_PREFIX + "person/" + id + "?api_key=" + API_KEY );

        if(res.IsSuccessStatusCode) {
            Data = await res.Content.ReadAsStringAsync();
            actor = JsonSerializer.Deserialize<Actor>(Data);
        }
        
        // Images
       res = await req.GetAsync(API_PREFIX + "person/" + id + "/images?api_key=" + API_KEY );

        if(res.IsSuccessStatusCode) {
            Data = await res.Content.ReadAsStringAsync();
            imageSet = JsonSerializer.Deserialize<ImageSet>(Data);
        }

        // popular
//popular?api_key=7775daa1ebc95476e157fa1148866a7e
        res = await req.GetAsync(API_PREFIX + "person/popular?api_key=" + API_KEY );

         

        
    } // ActorDetails


    

    // begin trending 
    public async Task GetTrending(){
        ClearHeaders();
    HttpResponseMessage res = 
            await req.GetAsync(API_PREFIX + "trending/movie/week?api_key=" + API_KEY );

        if(res.IsSuccessStatusCode) {
            Data = await res.Content.ReadAsStringAsync();
            trendSet = JsonSerializer.Deserialize<TrendSet>(Data);
        }
        
    } // GetTrending()

    // begin Search

    public async Task Search(string search) { 
        ClearHeaders();

        // Does a movie search
        HttpResponseMessage res = 
            await req.GetAsync(API_PREFIX + "search/movie?api_key=" + API_KEY + "&query=" + search);

        if(res.IsSuccessStatusCode) {
            Data = await res.Content.ReadAsStringAsync();
            posterSet = JsonSerializer.Deserialize<PosterSet>(Data);
        }
        else {
            Data = null;
        }
        
    } // Search()

        

    // begin Movie Deatails
    public async Task GetMovieDetails(string movieID) { 
        ClearHeaders();

        HttpResponseMessage res = 
            await req.GetAsync(API_PREFIX + "movie/" + movieID + "?api_key=" + API_KEY);

        if(res.IsSuccessStatusCode) {
            Details = await res.Content.ReadAsStringAsync();
            movie = JsonSerializer.Deserialize<Movie>(Details);
        }

        //movie Videos

         res = await req.GetAsync(API_PREFIX + "movie/" + movieID + "/videos?api_key=" + API_KEY);

        if(res.IsSuccessStatusCode) {
            Videos = await res.Content.ReadAsStringAsync();
            videoSet = JsonSerializer.Deserialize<VideoSet>(Videos);
        }

        // Movie actors

        res = await req.GetAsync(API_PREFIX + "movie/" + movieID + "/credits?api_key=" + API_KEY);

        if(res.IsSuccessStatusCode) {
            Credits = await res.Content.ReadAsStringAsync();
            castSet = JsonSerializer.Deserialize<CastSet>(Credits);
        }

    } // GetMovieDetails()

    
    
    public void ClearHeaders() {
        req.DefaultRequestHeaders.Accept.Clear();
        req.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));
    } // ClearHeaders()
        
} //class


