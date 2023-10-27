using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    public class CountryController
    {
        public List<Country> CountryDb = new List<Country>(); // Declare and initialize the list

        public void CountryAction(Country country)
        {
            CountryView countryView = new CountryView(country);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countryListView = new CountryListView(CountryDb);
            countryListView.Display();

            Console.WriteLine("Enter the index of the country you'd like to learn about:");
            if (int.TryParse(Console.ReadLine(), out int selectedCountryIndex) && selectedCountryIndex >= 1 && selectedCountryIndex <= CountryDb.Count)
            {
                CountryAction(CountryDb[selectedCountryIndex - 1]);
            }

            Console.WriteLine("Would you like to learn about another country? (yes/no)");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                WelcomeAction();
            }
        }
    }
}








