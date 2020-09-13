using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Install using nuggets from https://www.nuget.org/packages/OpenLocationCode
using Google.OpenLocationCode;

namespace PlusCode
{
    class Program
    {
        static void Main(string[] args)
        {
            double latitude = 34.537042;
            double longitude = 69.162293;
            
            // Converting latitude and longitude into pluscode
            OpenLocationCode encodedCode = new OpenLocationCode(latitude, longitude);
            string encodedCodeStr = encodedCode.Code;
            Console.WriteLine("Pluscode for coordinates ({0}, {1}) is {2}", latitude, longitude, encodedCodeStr);


            // Converting Pluscode to latitude and longitude 
            OpenLocationCode op = new OpenLocationCode(encodedCodeStr);
            CodeArea area = op.Decode();
            Console.WriteLine("Converting back from pluscode {0}", encodedCodeStr);
            Console.WriteLine("Latitude: {0} Longitude: {1}",area.CenterLatitude.ToString(), area.CenterLongitude.ToString());
            
            Console.ReadKey();
        }
    }
}
