using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather;

namespace world
{
    class Program
    {
        static void Main(string[] args)
        {
            string Longitude = "117.128411";
           string Latitude = "36.656786";
            SunTimeResult result = SunTimes.GetSunTime(DateTime.Now, double.Parse(Longitude), double.Parse(Latitude));
            Console.WriteLine(string.Format("今天日出时间:{0},日落时间:{1}", result.SunriseTime.ToString("HH:mm:ss"), result.SunsetTime.ToString("HH:mm:ss")));
            Console.ReadLine();
        }
    }
}
