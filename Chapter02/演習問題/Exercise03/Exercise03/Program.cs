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
            if (args[0] == "product") {
                salesDictionary = sales.GetPerProductCategory();
            }
            else if (args[0] == "store"){
                salesDictionary = sales.GetPerStoreSales();
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
