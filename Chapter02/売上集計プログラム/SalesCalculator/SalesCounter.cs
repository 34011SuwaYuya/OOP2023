using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {

    class SalesCounter {
        private List<Sale> _sales;

        public SalesCounter(string filPath) {
            _sales = ReadSales(filPath);
        }

        public Dictionary<string, int> GetPerStoreSales() {
        //public IDictionary<string, int> GetPerStoreSales_Ver2() {
           
            /*商品名ごとに集計するバージョン
             *Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ProductCategory)) {
                    dict[sale.ProductCategory] += sale.Amount;
                }
                else {
                    dict[sale.ProductCategory] = sale.Amount;
                }
            }
            return dict;
            */
            
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount;
                }
                else {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
             
        }


        private List<Sale> ReadSales(string filePath) {
            //private IEnumerable<Sale> ReadSales(string filePath) {
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
