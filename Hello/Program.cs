// See https://aka.ms/new-console-template for more information
using Entity;
using BzLayer;

MovieBz bz = new MovieBz();

List<Movies> movies = bz.GetMovies();
if(movies != null)
{
    foreach(var m in movies)
    {
        Console.WriteLine($"{m.id} {m.Name} {m.Ratings} {m.Ryear}");
    }
}
else
{
    Console.WriteLine("No Movies Present");
}