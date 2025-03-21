using System;
using Spectre.Console;
using Spectre.Console;
using Bogus;
using Bogus.DataSets;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker();

            BarChart bc = new BarChart();

            float number = new Bogus.Randomizer(1, 20);
        }
    }
}
