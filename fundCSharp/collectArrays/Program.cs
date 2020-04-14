﻿using System;
using System.Collections.Generic;
using System.IO;

namespace collectArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = @"/Users/samueljoseph/Desktop/PopbyLargestFinal.csv";
            
            CsvReader reader = new CsvReader(filePath);
            
            List<Country> countries = reader.ReadAllCountries();
           
            foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
