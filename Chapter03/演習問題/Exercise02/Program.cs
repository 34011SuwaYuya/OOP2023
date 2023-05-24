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

            //3.2-1
            var line = Console.ReadLine();
            int ans = names.FindIndex(s => s == line);
            Console.WriteLine(ans);
            Console.WriteLine("------");

            //3.2-2
            int oCount = names.Count(s => s.Contains('o'));
            Console.WriteLine(oCount);
            Console.WriteLine("------");


            //3.2-3
            var oNames = names.Where(s => s.Contains('o')).ToArray();
            foreach (var s in oNames) {
                Console.WriteLine(s);
               
            }
            Console.WriteLine("------");

            //3.2-4
            var namesStartB = names.Where(s => s.StartsWith("B")).Select(n => n.Length);
            foreach (var nu in namesStartB) {
                Console.WriteLine(nu);
            }
            Console.WriteLine("------");

        }
    }
}
