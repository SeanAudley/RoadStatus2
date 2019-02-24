using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RoadStatus
{
    class Program
    {
      

        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("Error Message");

                return 1;
            }

            string roadName;
            bool test = string.IsNullOrEmpty(args[0]);
            if (test == true)
            {
                System.Console.WriteLine("Please enter a valid road name");
                return 1;
            }
            else
            {
                roadName = args[0];
            }


            TfLRoadStatus route = new TfLRoadStatus(roadName);
            HttpStatusCode result = route.Retrieve();
            
            // Print result.
            if (result == HttpStatusCode.OK)
            {
                Console.WriteLine("The Status of the " + route.result[0].DisplayName + " is as follows");
                Console.WriteLine("\tRoad Status is "+ route.result[0].StatusSeverity);
                Console.WriteLine("\tRoad Status Description is "+ route.result[0].StatusSeverityDescription);
                return 0;
            }
            else
            {
                Console.WriteLine(route.errorResult.Message);
                return 1;
            }

        }
    }
    
}
