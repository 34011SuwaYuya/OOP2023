using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbr = new Abbreviations();
            Console.WriteLine(abbr.Count());
            Console.WriteLine(abbr.Remove("APEC"));

            Console.WriteLine(abbr.Count());

        }
    }
}
