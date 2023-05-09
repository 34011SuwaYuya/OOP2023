﻿using System;
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
            Console.Write("西暦：");
            year = int.Parse(Console.ReadLine());

            Console.Write("月：");
            month = int.Parse(Console.ReadLine());


            Console.Write("日：");
            day = int.Parse(Console.ReadLine());

            DateTime birthDay = new DateTime(year, month, day);
            DateTime today = DateTime.Today;

            DayOfWeek dayOfWeek = birthDay.DayOfWeek;
            string str = "〇〇";
            str = NewMethod(dayOfWeek);

            TimeSpan interval = today - birthDay;

            Console.WriteLine("あなたは生まれてから今日まで" + interval.Days + "日目です");
            Console.WriteLine("あなたは" + str + "に生まれました。");

        }

        private static string NewMethod(DayOfWeek dayOfWeek) {
            string str = "";
            switch ((int)dayOfWeek)
            {
                case 0:
                    str = "日曜日";
                    break;
                case 1:
                    str = "月曜日";
                    break;
                case 2:
                    str = "火曜日";
                    break;
                case 3:
                    str = "水曜日";
                    break;
                case 4:
                    str = "木曜日";
                    break;
                case 5:
                    str = "金曜日";
                    break;
                case 6:
                    str = "土曜日";
                    break;
            }

            return str;
        }
    }
}
