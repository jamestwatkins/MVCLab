using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Drawing;

namespace MVCCountriesLab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }


        public void Display()
        {
            string colors = string.Join(" ", DisplayCountry.Colors);
            Console.WriteLine($"Country: {DisplayCountry.Name} \nContinent: {DisplayCountry.Continent} \nColors: {colors}");

           
        }

    }
}
