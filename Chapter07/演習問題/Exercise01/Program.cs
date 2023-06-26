using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            string original = "Cozy lummox gives smart squid who asks for job pen";
            //original = original.

            Dictionary<char, int> abcDictionary = new Dictionary<char, int>();
            foreach (var item in Enumerable.Range('A', 26).Select(i => (char)i)) {
                abcDictionary.Add(item, 0);
            }

            char c;
            for (int i = 0 ; i < original.Length ; i++) {
                c = original[i];
                //abcDictionary[original[i]]++;
                Console.WriteLine(c);
            }

            //foreach (var item in abcDictionary) {
            //    Console.WriteLine("{0}:{1}", abcDictionary.Keys, abcDictionary.Values);
            //}

        }
    }
}
