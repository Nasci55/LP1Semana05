using System;
using Spectre.Console;
using Spectre.Console;
using Bogus;
using Bogus.DataSets;
using System.ComponentModel;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Randomizer.Seed = new Random(int.Parse(args[0]));
            Faker faker = new Faker();

            string brand = new Faker().Vehicle.Manufacturer();
            int sales = new Faker().Random.Number(0, 20);

            BarChart bc = new BarChart();

            int numero = int.Parse(args[0]);


            AnsiConsole.Write(bc
                .Width(20)
                .Label("Car Sales")
                .CenterLabel()
                .AddItem(brand, sales)

            );




        }
    }
}
