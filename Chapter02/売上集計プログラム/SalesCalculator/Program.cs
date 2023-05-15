using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter(ReadSales(@"data\Sales.csv"));
            //SalesCounter sales = new SalesCounter(SalesCounter.ReadSales(@"data\Sales.csv"));
            //SalesCounter内のReadSalesメソッドを呼び出して、そこからコンストラクタを呼び出す　内容は11行と同じ

            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            IDictionary<string, int> amountPerStore_Ver2 = sales.GetPerStoreSales_Ver2();

            foreach (KeyValuePair<string, int> obj in amountPerStore) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }


        }

        //売上データを読み込みSaleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;

        }
    }
}
