//#define NonArray
//#define StringArray
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            Stopwatch sw = new Stopwatch();
            sw.Start();
#if NonArray

            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            printBook(line);

            /*
            var words = line.Split(';');
            foreach (var item in words) {
                var pair = item.Split('=');
                Console.WriteLine("{0} : {1}", ToJapanese( pair[0]), pair[1]);
            }
            */

#elif StringArray
            var lines = new string[] {
                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1887",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",

                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1887",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",

                "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886",
                "Novelist=夏目漱石;BestWork=坊ちゃん;Born=1887",
                "Novelist=太宰治;BestWork=人間失格;Born=1909",
                "Novelist=宮沢賢治;BestWork=銀河鉄道の夜;Born=1896",
            };
            printBooksForArray(lines);
            /*
            foreach (var line in lines) {
                var words = line.Split(';');
                foreach (var item in words) {
                    var pair = item.Split('=');
                    Console.WriteLine("{0} : {1}", ToJapanese(pair[0]), pair[1]);
                }
            }
            */


#endif
            Console.WriteLine("実行時間　＝　{0}", sw.Elapsed.ToString(@"ss\.ffff"));
        }

        private static string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "引数エラー";
            }
        }

        private static string[] lineDecompose(string line) {

            var words = line.Split(';');

            int equalPoint;
            for (int i = 0; i < words.Length; i++) {
                equalPoint = words[i].IndexOf('=');
                words[i] = words[i].Remove(0, equalPoint + 1);

            }

            return words;
        }
#if NonArray 
        //１冊の本用のメソッド
        private static void printBook(string line) {
            
            var formatWords = new String[]{
                "作家　：",
                "代表作：",
                "誕生年：",
            };

            var words = lineDecompose(line);
            for (int i = 0; i < words.Length; i++) {
                Console.WriteLine(formatWords[i] + words[i]);
            }
        }
#endif
#if StringArray

        //複数の本用のメソッド
        private static void printBooksForArray(string[] lines) {

            var formatWords = new String[]{
                "作家　：",
                "代表作：",
                "誕生年：",
            };
            var words = new string[3];

            for (int i = 0; i < lines.Length; i++) {
                words = lineDecompose(lines[i]);
                for (int j = 0; j < words.Length; j++) {
                    Console.WriteLine(formatWords[j] + words[j]);
                }
                Console.WriteLine("----------------");
            }
        }
#endif
    }
}
