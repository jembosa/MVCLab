using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace MVCLab
{
    class Program
    {
        static void Main()
        {
            // Create some sample country data
            List<Country> countries = new List<Country>
        {
            new Country
            {
                Name = "USA USA USA USA",
                Continent = "North America",
                Colors = new List<string> { "Red", "White", "Blue" }
            },
            new Country
            {
                Name = "Canada",
                Continent = "North America",
                Colors = new List<string> { "Red", "White" }
            },
               new Country
            {
                Name = "Italy",
                Continent = "Europe",
                Colors = new List<string> { "Red", "White", "Green" }
            },
            // More countries here
        };

            // Initialize the controller and populate the CountryDb
            CountryController controller = new CountryController();
            controller.CountryDb.AddRange(countries);

            // Start the app
            controller.WelcomeAction();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
    





