using Entity;
using DataLayer;

namespace BzLayer;
public class MovieBz
{
    public List<Movies> GetMovies()
    {
        DataAccess dataAccess = new DataAccess();
        return dataAccess.GetMovies();
    }
}
