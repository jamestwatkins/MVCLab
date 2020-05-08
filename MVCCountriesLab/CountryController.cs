using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    class CountryController
    {
        List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb = new List<Country>();

            CountryDb.Add(new Country("USA", "North America", new List<string>() { "Red", "White", "Blue" }));
            CountryDb.Add(new Country("Brazil", "South America", new List<string>() { "Yellow", "Green", "Blue" }));
            CountryDb.Add(new Country("Canada", "North America", new List<string>() { "Red", "White" }));
            CountryDb.Add(new Country("Albania", "Europe", new List<string>() { "Red", "Black" }));
            CountryDb.Add(new Country("China", "Asia", new List<string>() { "Red", "Yellow" }));
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);

            cv.Display();
        }
        
        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);

            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");

            clv.Display();

            Console.WriteLine("Please select a country:");

            while (true) {

                string input = Console.ReadLine();

                Console.WriteLine();

                int index = 0;

                bool isNum = int.TryParse(input, out index);

                string again = "";

                if (isNum)
                {
                    try
                    {
                        CountryAction(CountryDb[index - 1]);

                        Console.WriteLine();

                        Console.WriteLine("Would you like to learn about another country? y for yes, anything else to exit:");

                        again = Console.ReadLine();
                        
                    }
                    catch
                    {
                        Console.WriteLine("Plase enter a valid country index:");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Plase enter a valid country index:");
                    continue;
                }


                        if(again == "y")
                        {
                    Console.Clear();
                            WelcomeAction();
                        }
                        else
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                break;
            }

        }
    }
}
