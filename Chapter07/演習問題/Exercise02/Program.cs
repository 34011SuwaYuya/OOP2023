using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var abbr = new Abbreviations();

            abbr.Add("IOC", "国際オリンピック委員会");
            abbr.Add("NPT", "核拡散防止条約");

            //7.2.3 Countの呼び出し
            Console.WriteLine(abbr.Count());
            Console.WriteLine();


            Console.WriteLine("削除前の要素数" + abbr.Count);
            //Remove呼び出し
            if (abbr.Remove("NPT")){
                Console.WriteLine("削除後" + abbr.Count);
            }
            if (!abbr.Remove("NPT")) {
                Console.WriteLine("削除できません");
            }
            Console.WriteLine();


            Console.WriteLine("削除後の要素数" + abbr.Count());
            Console.WriteLine();

            foreach (var item in abbr.FindSpecific(3)) {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }

        }
    }
}
