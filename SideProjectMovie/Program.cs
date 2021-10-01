using System;

namespace SideProjectMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie dieHard = new Movie("Die Hard");
            dieHard.GetDirector("John McTiernan");
            dieHard.Book(true); //1979 Novel "Nothing Lasts Forever" by Roderick Thorp

            Console.WriteLine(dieHard.Title + " is directed by " + dieHard.Director); 
            Console.WriteLine("Was " + dieHard.Title + " a book before it was a movie? " + dieHard.BookFirst);

        }
    }
}
