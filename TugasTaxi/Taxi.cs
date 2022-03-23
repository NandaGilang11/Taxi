using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    class Taxi
    {
        // Properties
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public int NumPassenger { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Name Driver\t : {0}", DriverName);
            Console.WriteLine("On Duty\t\t : {0}", OnDuty);
            Console.WriteLine("Number Passegers : {0}", NumPassenger);

        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} picking up passengers", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} carrying passengers\n", DriverName);
        }
    }
}
