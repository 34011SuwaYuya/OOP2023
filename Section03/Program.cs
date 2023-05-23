using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var list = new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            var existence = list.Exists(s => s[0] == 'B');
            Console.WriteLine(existence);

            var name = list.Find(s => s.Length == 6);
            Console.WriteLine("6文字：" + name);

            var names = list.ConvertAll(s => s.ToLower());
            foreach(var s in names) {
                Console.WriteLine(s);
            }


            int index = list.FindIndex(s => s == "Berlin");
            Console.WriteLine(index);

            var removeCount = list.RemoveAll(s => s.Contains("on"));
            Console.WriteLine(removeCount);

            list.ForEach(s => Console.WriteLine(s));
        }
    }
}
