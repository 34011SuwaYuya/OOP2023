using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            //var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DateTime dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            //2019/1/15 19:48
            Console.WriteLine(dateTime.ToString("yyyy/MM/dd HH:mm"));

        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //2019年01月15日 19時48分32秒
            Console.WriteLine(dateTime.ToString("yyyy年{0:00}月{1:00}日 HH時mm分ss秒"), dateTime.Month, dateTime.Day);
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            //平成31年　1月15日（火曜日)
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            Console.WriteLine(dateTime.ToString("ggyy年M月d日(dddd)"), culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek));
        }

        private static void DisplayDatePattern3_2(DateTime date) {

        
        }
    }
}
