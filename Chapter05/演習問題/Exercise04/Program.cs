using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {
            var originalString = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
            var words = originalString.Split(';');
            int equalPoint;
            for (int i = 0; i < words.Length; i++) {
                equalPoint = words[i].IndexOf("=");
                words[i] = words[i].Remove(0 , equalPoint + 1);
            }

            foreach (var item in words) {
                Console.WriteLine(item);
            }

            var formatWords = new String[]{
                "作家　：",
                "代表作：",
                "誕生年：",
            };
            for (int i = 0; i < words.Length; i++) {
                Console.WriteLine(formatWords[i] + words[i]);
            }
         }
    }
}
