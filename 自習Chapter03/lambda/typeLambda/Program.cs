using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeLambda {
    class Program {
        static void Main(string[] args) {

            var list = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"};


            var exists = list.Exists(s => s[0] == 'A');
            Console.WriteLine(exists);


            var name = list.Find(s => s.Length == 6);
            Console.WriteLine(name);


            //int index = list.FindAll();
            Console.WriteLine();
            
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
