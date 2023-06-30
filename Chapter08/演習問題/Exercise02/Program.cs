using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            //DateTime dateTime = DateTime.Now;


            foreach (var item in Enum.GetValues(typeof(DayOfWeek))) {
                Console.Write(dateTime.ToString("d") + "の次の" + item);
                Console.WriteLine(NextDay(dateTime, (DayOfWeek)item));
            }

        }

        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)( date.DayOfWeek );
            if (days <= 0) {
                days += 7;
            }
            return date.AddDays(days);
        }
    }
}
