using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new  List<string>{
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);

        }

        private static void Exercise2_1(List<string> names) {

            //3.2-1
            var line = "";


            Console.WriteLine("***** 3.1 *****");
            Console.WriteLine("都市名を入力。空行で終了");

            do {
                line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) {
                    break;
                }
                int ans = names.FindIndex(s => s == line);
                Console.WriteLine(ans);
            } while (true);
          
        }

        private static void Exercise2_2(List<string> names) {
            //3.2-2

            Console.WriteLine("***** 3.2 *****");
            int oCount = names.Count(s => s.Contains('o'));
            Console.WriteLine(oCount);

        }

        private static void Exercise2_3(List<string> names) {

            //3.2-3
            Console.WriteLine("***** 3.3 *****");
            var oNames = names.Where(s => s.Contains('o')).ToArray();
            foreach (var s in oNames) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise2_4(List<string> names) {
            Console.WriteLine("***** 3.4 *****");
            //var namesStartB = names.Where(s => s.StartsWith("B")).Select(s => s + "," + s.Length);
            var namesStartB = names.Where(s => s.StartsWith("B")).Select(s =>new {s , s.Length });
            //newでインスタンスを作成して配列化できる

            foreach (var item in namesStartB) {
                Console.WriteLine("{0},{1}",item.s , item.Length);
            }
        }
    }
}
