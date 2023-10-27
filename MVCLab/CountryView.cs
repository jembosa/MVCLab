using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    public class CountryView
    {
        public Country DisplayCountry { get; private set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine("Colors:");
            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine($"- {color}");
            }
        }
    }
}