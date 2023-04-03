namespace MovieMania.Pages;

public class ActorModel : PageModel{


    public Fetch fetch = new Fetch();
    public int age;



    public  async Task OnGet(string id){
        await fetch.ActorDetails(id);

        string birthDate = fetch.actor.birthday;
        string birthYear = birthDate.Substring(0, 4);

        age = DateTime.Now.Year - Convert.ToUInt16(birthYear);
        
}   



    


} //class