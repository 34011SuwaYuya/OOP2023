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
            Console.WriteLine("空白数：{0}", blankNum);
            //Console.WriteLine(text.Count(c => c == ' '));
        }

        private static void Exercise3_2(string text) {

            var newText = text.Replace("big", "small");
            Console.WriteLine(newText);
        }

        private static void Exercise3_3(string text) {
            var words = text.Split(' ');
            Console.WriteLine("単語数：{0}" , words.Length);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(s => s.Length <= 4);
            foreach (var item in words) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise3_5(string text) {
            var words = text.Split(' ').ToArray();
            //.ToArray()で即時実行する

            //長さが０の場合には何もしない
            if(words.Length > 0) {

            }


            StringBuilder sb = new StringBuilder();

            foreach (var item in words) {
                sb.Append(item);
                sb.Append(' ');
            }

            string str2 = sb.ToString().TrimEnd();
            //trimendは現在のstringを変更せず新しいstringを返す
            //stringBuilderをわざわざ使う意味がない
            Console.WriteLine(str2);


            /*
             * スキップを使えばforeach内の途中から使える
            StringBuilder sb = new StringBuilder(words[0]);
            foreach (var item in words.Skip(1)) {
                sb.Append(' ');
                sb.Append(item);
            }
            Console.WriteLine(sb.ToString())
            */
        }
    }
}
