using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var texts = new[] {
               "Time is money.",
               "What time is it?",
               "It will take time.",
               "We reorganized the timetable.",
            };

            foreach (var item in texts) {
                var matches = Regex.Matches (item, @"\btime\b", RegexOptions.IgnoreCase);
                foreach (Match match in matches) {
                    Console.WriteLine ( match.Index );
                }
            }
            




        }
    }
}
