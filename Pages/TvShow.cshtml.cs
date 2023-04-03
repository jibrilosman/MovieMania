namespace MovieMania.Pages;

public class TvShowModel : PageModel {

  public FetchTv fetchTv = new FetchTv();

  public async Task OnGet(){
      await fetchTv.GetTrending();
  }

  public async Task OnPostTvShowSearch(string search) {
        await fetchTv.Search(search);
    }

    
    public async Task OnPostMovieDetails(string tvID) {
        await fetchTv.GetMovieDetails(tvID);
    }
} // class










