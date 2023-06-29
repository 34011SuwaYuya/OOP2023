using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbr = new Abbreviations();

            Console.WriteLine("7.2.3");
            Console.WriteLine(abbr.Count());
            Console.WriteLine(abbr.Remove("APEC"));

            Console.WriteLine(abbr.Count());
            Console.WriteLine();

            var specificAbbr = abbr.FindSpecific(3);
            foreach (var item in specificAbbr) {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }

        }
    }
}
