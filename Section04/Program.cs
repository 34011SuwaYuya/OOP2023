using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            var names= new List<string> {
                "Tokyo",
                "New Delhi",
                "Bangkok",
                "London",
                "Paris",
                "Berlin",
                "Canberra",
                "Hong Kong",
            };

            #region
            //IEnumerable<string> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());
            //var query = names.Select(s => s.ToLower());
            //foreach (var s in query) {
            //    Console.WriteLine(s);
            //}
            #endregion 

            //ToListが即時実行なので、その前にあるwhere(遅延実行)もすぐに実行される
            var query = names.Where(s => s.Length <= 5).ToList();   
            //var query = names.Where(s => s.Length <= 5);
            foreach (var item in query) {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");


            names[0] = "Osaka";
            //元のリストであるnamesが書き換えられても、書き換え前に作ったqueryには反映されないはず
            //しかし、遅延実行の関係でnamesが書き換えられてからqueryが作られる
            foreach (var item in query) {
                //in queryで初めて必要になるので、このタイミングでqueryが作られる
                Console.WriteLine(item);
            }
        }
    }
}
