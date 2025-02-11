using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Bike
{
    internal class Program
    {
        static void Main()
        {
            // #1 - Put code here to construct 5 bikes

            Bike bike1 = new Bike("Thunderbolt", 45639, 25.00, "Alex Strong", "Road");
            Bike bike2 = new Bike("Sugeno", 56390, 30.00, "Johny Cash", "Mountain");
            Bike bike3 = new Bike("Mongus", 95976, 20.00, "Miley Cyrus", "Street");
            Bike bike4 = new Bike("Raodrunner", 39001, 35.00, "Lady Gaga", "Terrain");
            Bike bike5 = new Bike("Scorpion", 67392, 30.00, "Bradley Cooper", "Mountain");

            Bike[] bikes = { bike1, bike2, bike3, bike4, bike5 };

            bike2.IsElectricBike();

            WriteLine("Bikes we Rent:");
            WriteLine("--------------");

            //#2 - Call the BikeDisplay method to display the bike objects
            BikeDisplay(bikes);
            
        }

        public static void BikeDisplay(Bike[] bikes)
        {
            // #3 - Use a foreach loop to dislay the bike objects
            foreach (Bike bike in bikes)
            {
                Console.WriteLine(bike);
            }
        }
    }
}
