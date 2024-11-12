using Movie_Database;
using System.Reflection;

List<Movie> movies = new List<Movie>
{
    new ("The Lion King", "Animated"),
    new ("The Ring", "Horror"),
    new ("The Great Gatsby", "Drama"),
    new ("El Camino", "Drama"),
    new ("The Nightmare Before Christmas", "Animated"),
    new ("Independence Day", "Scifi"),
    new ("Gone Girl", "Drama"),
    new ("The Conjuring", "Horror"),
    new ("Shrek", "Animated"),
    new ("Interstellar", "Scifi"),
};

bool agreeContinue = false;
Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine();

do
{
    Console.WriteLine($"There are {movies.Count} movies in this list.");
    bool validCategory = false;
    while (validCategory == false)
    {
        Console.WriteLine("What category would you like? You can enter \"animated\", \"horror\", \"drama\", or \"scifi\".");
        string userCategory = Console.ReadLine().ToLower();
        var categoryType = movies.Where(x => x.movieCategory.Equals(userCategory, StringComparison.OrdinalIgnoreCase)).OrderBy(x => x.movieTitle).ToList();
        {
            if (categoryType.Count > 0)
            {
                Console.WriteLine($"The following movies are in the {userCategory} category:");
                validCategory = true;
                foreach (var movie in categoryType)
                {
                    movie.DisplayMovie();
                }
            }
            else
            {
                Console.WriteLine($"Sorry, there are no movies in the {userCategory} category");
                validCategory = false;
            }
        }
    }
    Console.WriteLine("Would you like to continue? (y/n)");
    string userAgree = Console.ReadLine().ToLower();
    if (userAgree == "y")
    {
        agreeContinue = true;
    }
    else
    {
        agreeContinue = false;
        Console.WriteLine("Goodbye!");
    }
} while (agreeContinue == true);

// What advantages can you get from storing multiple objects into a collection when compared to having each object as its own variable?

// The main advantages of storing multiple objects into a collection rather than having each object as its own variable is simplified/shorter code (the ability to loop through
// a collection via a foreach loop rather than several if/else statements), ease of adding new objects to the collection rather than having to make new variables and likely 
// new/altered code for each new object, and the ease of filtering collections for data using LINQ.



