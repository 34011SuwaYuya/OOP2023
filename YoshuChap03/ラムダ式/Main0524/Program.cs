using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main0524 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string>{
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
            };

            var query = names.Where(s => s.Length <= 5);
            foreach (var item in query) {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");

            names[0] = "Osaka";
            //元のリストであるnamesが書き換えられても、書き換え前に作ったqueryには反映されないはず
            //しかし、遅延実行の関係でnamesが書き換えられてからqueryが作られる
            foreach (var item in query) {
                Console.WriteLine(item);
            }

        }
    }
}
