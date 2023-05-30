using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var ym = new YearMonth(2023, 5);
            Console.WriteLine(ym);
            
            YearMonth[] yearMonthArray = new YearMonth[] {
                new YearMonth(1999, 12),
                new YearMonth(2000, 3),
                new YearMonth(2001, 9),
                new YearMonth(2023, 1),
                new YearMonth(2023,5),
            };
            
               
        }
    }
}
