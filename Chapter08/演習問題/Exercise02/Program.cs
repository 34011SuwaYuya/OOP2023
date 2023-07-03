using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            #region Now
            DateTime dateTime = DateTime.Now;


            foreach (var item in Enum.GetValues(typeof(DayOfWeek))) {
                Console.Write(dateTime.ToString("d") + "の次週の" + item +"：");

                Console.WriteLine(NextDay2nd(dateTime, (DayOfWeek)item).ToString("yy/MM/dd(ddd)" ));
            }

            Console.WriteLine();
            Console.WriteLine(); 
            Console.WriteLine();
            #endregion

            #region 2019/01/15
            var datetime2 = new DateTime(2019, 1, 15, 19, 48, 32);
            


            foreach (var item in Enum.GetValues(typeof(DayOfWeek))) {
                Console.Write(datetime2.ToString("d") + "の次週の" + item + "：");

                Console.WriteLine(NextDay2nd(datetime2, (DayOfWeek)item).ToString("yy/MM/dd(ddd)"));
            }

            #endregion
        }

        public static DateTime NextDay2nd(DateTime date, DayOfWeek dayOfWeek) {

            date = date.AddDays(7);

            int days = (int)dayOfWeek - (int)date.DayOfWeek;

            return date.AddDays(days);
        }
    }
}
