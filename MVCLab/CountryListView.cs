using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    public class CountryListView
    {
        public List<Country> Countries { get; private set; }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Countries[i].Name}");
            }
        }
    }
}
