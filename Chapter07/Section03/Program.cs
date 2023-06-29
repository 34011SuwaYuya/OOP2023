using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var abbr = new Abbreviations();

            //Addメソッドの呼び出し例
            abbr.Add("IOC", "国際オリンピック委員会");
            abbr.Add("NPT", "核兵器不拡散条約");

            //インデクサの利用
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names) {
                var fullname = abbr[name];



                if (fullname == null) {
                    Console.WriteLine("{0}は見つかりません", name);
                }else {
                    Console.WriteLine("{0} = {1}", name, fullname);
                }
                

            }

            //ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbr.ToAbbreviation(japanese);


            if (abbreviation== null) {
                Console.WriteLine("{0}は見つかりません", japanese);
            }
            else {
                Console.WriteLine("{0} = {1}", japanese, abbreviation);
            }


            //FillAllメソッドの利用例
            foreach (var item in abbr.FindAll("国際")) {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }

     
    }
}
