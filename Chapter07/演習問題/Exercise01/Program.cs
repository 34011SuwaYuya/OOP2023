using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static Dictionary<char, int> _dict = new Dictionary<char, int>();

        static void Main(string[] args) {
            
            string text = "Cozy lummox gives smart squid who asks for job pen".ToUpper();

            Exercise1_1(text);
            Console.WriteLine("**************:");
            Exercise1_2(text);


        }

        private static void Exercise1_1(string text) {
            
            foreach (var ch in text) {
                if ('A' <= ch && ch <= 'Z') {
                    if (_dict.ContainsKey(ch)) {
                        _dict[ch]++;
                    }
                    else {
                        _dict.Add(ch, 1);
                    }
                }
            }
            foreach (var keyValuePair in _dict.OrderBy(x => x.Key)) {
                Console.WriteLine("{0}:{1}", keyValuePair.Key, keyValuePair.Value);
            }
        }

        private static void Exercise1_2(string text) {
            SortedDictionary<char, int> sortedPairs = new SortedDictionary<char, int>();
            foreach (var ch in text) {

                if ('A' <= ch && ch <= 'Z') {
                    if (sortedPairs.ContainsKey(ch)) {
                        sortedPairs[ch]++;
                    }
                    else {
                        sortedPairs.Add(ch, 1);
                    }
                }
            }
            foreach (var item in sortedPairs) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
}
