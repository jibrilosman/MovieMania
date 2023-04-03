namespace MovieMania;

public class FetchTv {


    public TvPosterSet? tvPosterSet;
    public TvTrendSet? tvTrendSet;
    public TvShow? tvShow;




    public HttpClient req = new HttpClient();
    
    public const string API_KEY = "7775daa1ebc95476e157fa1148866a7e";
    public const string API_PREFIX = "https://api.themoviedb.org/3/";
    public string? Data {get; set;}
    public string? Details {get; set;}
    public string? Videos {get; set;}


// begin trend

    public async Task GetTrending(){
        ClearHeaders();


    HttpResponseMessage res = 
            await req.GetAsync(API_PREFIX + "trending/tv/week?api_key=" + API_KEY);
            

        if(res.IsSuccessStatusCode) {
            Details = await res.Content.ReadAsStringAsync();
            tvTrendSet = JsonSerializer.Deserialize<TvTrendSet>(Details);
        }
        
    } // GetTrending()


    public async Task Search(string search){
        ClearHeaders();

    
        HttpResponseMessage res = 
        await req.GetAsync(API_PREFIX + "search/tv?api_key=" + API_KEY + "&query" + search);

        if(res.IsSuccessStatusCode) {
            Data = await res.Content.ReadAsStringAsync();
            tvPosterSet = JsonSerializer.Deserialize<TvPosterSet>(Data);
        }
        else {
            Data = null;
        }
    } // Search()

    //*************************************
    //*************************************

    public async Task GetMovieDetails(string tvID){
        ClearHeaders();


         HttpResponseMessage res = 
        await req.GetAsync(API_PREFIX + "tv/" + tvID + "?api_key=" + API_KEY);

        if(res.IsSuccessStatusCode) {
            Details = await res.Content.ReadAsStringAsync();
            tvShow = JsonSerializer.Deserialize<TvShow>(Details);
        }

    }
    

    public FetchTv(){}

    public void ClearHeaders() {
        req.DefaultRequestHeaders.Accept.Clear();
        req.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("applicationException/json"));
    } // ClearHeaders()

} // Class