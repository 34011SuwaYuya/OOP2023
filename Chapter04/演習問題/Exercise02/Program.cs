using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {


            // 4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);
            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("\n- 4.2.5 ---");


            // 4.2.5
            Exercise2_5(ymCollection);
        }
        private static void Exercise2_2(YearMonth[] ymCollection) {
            Array.ForEach(ymCollection, s => Console.WriteLine(s));
        }


        //4.2.3
        static YearMonth Find21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }


        private static void Exercise2_4(YearMonth[] ymCollection) {
            var ym = Find21C(ymCollection);

            if (ym == null)
                Console.WriteLine("a");

            if (ym == null) {
                Console.WriteLine("21世紀のデータはありません");
            }
            else {
                Console.WriteLine(ym.Year);
            }

        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var addedYearMonth = ymCollection.Select(y => y.AddOneMonth());

            foreach (var item in addedYearMonth) {
                Console.WriteLine(item);
            }
        }

    }
}