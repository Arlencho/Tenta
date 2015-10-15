using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightFacade.PrepareForTakeoff("SAS1234", "WEST 1");

            Console.ReadKey();
        }
    }
}
