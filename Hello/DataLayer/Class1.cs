using Entity;
namespace DataLayer;
public class DataAccess
{
    public static List<Movies> movies =new List<Movies>() 
    {
        new Movies{id=1,Name="Toofan",Ryear=2021,Ratings=3},
        new Movies{id=2,Name="Ludo",Ryear=2020,Ratings=4},
        new Movies{id=3,Name="Gunjan",Ryear=2020,Ratings=1},
        new Movies{id=4,Name="Big Bull",Ryear=2021,Ratings=3},
        new Movies{id=5,Name="Laxmi",Ryear=2020,Ratings=2}
    };

    public List<Movies> GetMovies()
    {
        return movies;
    }
}
