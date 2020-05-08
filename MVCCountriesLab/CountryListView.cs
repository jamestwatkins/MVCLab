using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            foreach(Country c in Countries)
            {
                int i = Countries.IndexOf(c) + 1;

                Console.WriteLine($"{i}. {c.Name}");
            }
        }
    }
}
