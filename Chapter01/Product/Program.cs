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


            Console.WriteLine("今日の日付：" + date.Year + "年" + date.Month + "月" + date.Day + "日");
            Console.WriteLine("１０日後：" + dayAfter10.Year + "年" + dayAfter10.Month + "月" + dayAfter10.Day + "日");
            Console.WriteLine("１０日前：" + dayBefore10.Year + "年" + dayBefore10.Month + "月" + dayBefore10.Day + "日");
            #endregion


            int year;
            int month;
            int day;

            Console.WriteLine("誕生日を入力");
            //西暦を入力
            Console.Write("西暦：");
            year = int.Parse(Console.ReadLine());
            //月を入力
            Console.Write("月：");
            month = int.Parse(Console.ReadLine());
            //日を入力
            Console.Write("日：");
            day = int.Parse(Console.ReadLine());

            DateTime birthDay = new DateTime(year, month, day);
            DateTime today = DateTime.Today;

            //演習2
            TimeSpan interval = today - birthDay;

            //演習3
            DayOfWeek dayOfWeek = birthDay.DayOfWeek;   //dayOfWeekは英語で曜日が出る Tuesday
            string str = "〇〇";
            str = dayReturn(dayOfWeek);


            Console.WriteLine("あなたは生まれてから今日まで" + interval.Days + "日目です");
            Console.WriteLine("あなたは" + str + "に生まれました。");
        
        }

        #region dayReturnメソッド
        private static string dayReturn(DayOfWeek dayOfWeek) {
            string str = "";
            string[] days = { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日", };
            str = days[(int)dayOfWeek];
            return str;
        }
        #endregion 
    }
}
