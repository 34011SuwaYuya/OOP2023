using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            SalesCounter sales = new SalesCounter(@"data\Sales.csv");


            IDictionary<string, int> amountPerProduct = sales.GetPerProductCategory();

            foreach (KeyValuePair<string, int> obj in amountPerProduct) {
                Console.WriteLine("{0} {1:#,000}", obj.Key, obj.Value);
            }
        }
    }
}
