
namespace MovieMania.Pages;

public class IndexModel : PageModel
{
    public int maxVideos = 3;
    public int maxCast = 6;
    public string? convertedBudget;
    public Fetch fetch = new Fetch();


    public async Task OnGet(){
        await fetch.GetTrending();
    }

    public async Task OnPostMovieSearch(string search) {
        await fetch.Search(search);
    }

    

    public async Task OnPostMovieDetails(string movieID) {
        await fetch.GetMovieDetails(movieID);

    convertedBudget = string.Format("{0:c}", fetch.movie.budget);
    int vidCount = fetch.videoSet.results.Count;
    if(vidCount < maxVideos)
        maxVideos = vidCount;
    }

    public async Task OnPostGetActor(string actorID){
        Response.Redirect("/Actor?id=" + actorID);

    }

}// class
