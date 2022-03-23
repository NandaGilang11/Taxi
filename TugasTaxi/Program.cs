using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek Taxi
            Taxi taxi = new Taxi();
            Taxi taxi2 = new Taxi();

            // Properties value
            taxi.DriverName = "Itadori";
            taxi.OnDuty = "Yes";
            taxi.NumPassenger = 11;

            taxi2.DriverName = "Fushiguro";
            taxi2.OnDuty = "Yes";
            taxi2.NumPassenger = 18;

            // Pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            taxi2.TaxiInfo();
            taxi2.PickUpPassenger();
            taxi2.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
