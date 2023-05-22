using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            SalesCounter sales = new SalesCounter(@"data\Sales.csv");

            IDictionary<string, int> salesDictionary;
            Console.WriteLine("1:店舗別売り上げ");
            Console.WriteLine("2:商品カテゴリー別売り上げ");

            //分岐はcaseが望ましい
            if (args[0] == "1") {
                
                salesDictionary = sales.GetPerStoreSales();
            }
            else if (args[0] == "2"){
                salesDictionary = sales.GetPerProductCategory();
            }
            else {
                salesDictionary = null;
            }

            

            foreach (KeyValuePair<string, int> obj in salesDictionary) {
                Console.WriteLine("{0} {1:#,000}", obj.Key, obj.Value);
            }
        }
    }
}
