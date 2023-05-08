using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {


    
    class Program {
        static void Main(string[] args) {

            #region P26            
            /*
            //インスタンスの生成（オブジェクトの生成）
            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(235, "大福もち", 160);

            Console.WriteLine("かりんとうの税込価格" + karinto.GetPriceIncludingTax());
            Console.WriteLine( karinto.ToString()) ;

            Console.WriteLine("大福もちの税込価格" + daifuku.GetPriceIncludingTax());
            Console.WriteLine(daifuku.ToString());
            */
            #endregion

            #region 日付計算
            DateTime date = DateTime.Today;
            DateTime dayAfter10 = date.AddDays(10);
            DateTime dayBefore10 = date.AddDays(-10);

            
            Console.WriteLine("今日の日付：" + date);
            Console.WriteLine("１０日後：" + dayAfter10);
            Console.WriteLine("１０日前：" + dayBefore10);
            #endregion



        }
    }
}
