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
            // string Longitude = "117.128411";
            //string Latitude = "36.656786";
            // SunTimeResult result = SunTimes.GetSunTime(DateTime.Now, double.Parse(Longitude), double.Parse(Latitude));

            // Console.WriteLine(string.Format("今天日出时间:{0},日落时间:{1}", result.SunriseTime.ToString("HH:mm:ss"), result.SunsetTime.ToString("HH:mm:ss")));

            //   // 本周：

            //  string a= DateTime.Now.AddDays(0 - Convert.ToInt16(DateTime.Now.DayOfWeek)+1).ToString();

            //  string  v= DateTime.Now.AddDays(6 - Convert.ToInt16(DateTime.Now.DayOfWeek)+1).ToString();

            //   //上周：

            //string  c=   DateTime.Now.AddDays(0 - Convert.ToInt16(DateTime.Now.DayOfWeek) - 7).ToString();

            //string  d=   DateTime.Now.AddDays(6 - Convert.ToInt16(DateTime.Now.DayOfWeek) - 7).ToString();


            // Console.WriteLine(a+"|"+v+ "|" + c+ "|" + d);

            DateTime dt = Convert.ToDateTime("2021年8月5日"); //当前时间  
            //本周
            //取当前日期的周一
            DateTime monday = GetWeekFirstDate(dt);
            //string weekNowBegin = monday.ToString("yyyy-MM-dd 00:00:00");

            string weekNowEnd = monday.AddDays(6).ToString("yyyy-MM-dd 23:59:59");
            //上周
            string lastWeekNowBegin = monday.AddDays(-7).ToString("yyyy-MM-dd 00:00:00");
            // string lastWeekNowEnd = monday.AddDays(-1).ToString("yyyy-MM-dd 23:59:59");

        }
        /// <summary>  
        /// 获取本周第一天（以星期一为第一天）
        /// </summary>  
        /// <param name="dateTime">当前时间 DateTime.Now or DateTime.UtcNow</param>  
        /// <returns>后面的具体时、分、秒和传入值相等</returns>  
        public static DateTime GetWeekFirstDate(DateTime dateTime)
        {
            int weeknow = Convert.ToInt32(dateTime.DayOfWeek);

            // 因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            // 本周第一天
            return Convert.ToDateTime(dateTime.AddDays(daydiff));
        }
    }
}
