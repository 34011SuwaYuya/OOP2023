using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            
        }

        private static void Exercise3_1(string text) {
            int blankNum = text.Count(c => c == ' ');
            Console.WriteLine(blankNum);
        }

        private static void Exercise3_2(string text) {

            var newText = text.Replace("big", "small");
            Console.WriteLine(newText);
        }

        private static void Exercise3_3(string text) {
            var words = text.Split(' ');
            Console.WriteLine(words.Length);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var item in words) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise3_5(string text) {
            var words = text.Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach (var item in words) {
                sb.Append(item + " ");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
