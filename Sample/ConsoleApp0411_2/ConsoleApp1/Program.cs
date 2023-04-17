using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            int pay_amount;
            int budget;
            int count_bill = 0;
            //int[] bills = {10000, 5000, 1000, 500, 100, 50, 10, 5, 1};
            //String[] bill_name = {"一万円札", "五千円札", "千円札", "五百円玉", "百円玉", "五十円玉", "十円玉", "五円玉", "一円玉", };


            int[] bill_integer = { 10000, 5000, 2000, 1000, 500, 100, 50, 10, 5, 1 };
            String[] bill_name = { "一万円札", "五千円札"," 二千円札","千円札", "五百円玉", "百円玉", "五十円玉", "十円玉", "五円玉", "一円玉", };

            int[] bill_count = new int [bill_integer.Length];
            

            //bills.lengeth = 9;
            Console.Write("購入金額を入力：");
            pay_amount = int.Parse(Console.ReadLine());
            Console.Write("支払金額を入力：");
            budget = int.Parse(Console.ReadLine());

            if (pay_amount > budget)
            {
                Console.WriteLine("支払金額が足りてない");
            }

            budget = budget - pay_amount;
            Console.WriteLine("おつりの合計金額は" + budget + "円");
            for (int i = 0; i < bill_integer.Length; i++)
            {
                count_bill = budget / bill_integer[i];
                bill_count[i] = count_bill;
                budget -= count_bill * bill_integer[i];
                //budget = budget % bills[i]        模範解答によるおつりの計算
            }

            for (int m = 0; m < bill_integer.Length; m++)
            {
                //Console.WriteLine(bill_name[m] + "円は" + bill_num[m] + "枚");

                Console.Write(bill_name[m] + "円は" );
                astOut(bill_count[m]);    //＊を使った枚数表示メソッドを呼び出す
            }

            Console.WriteLine("終了");
        }


        private static void astOut(int times) {
            for (int i = 0; i < times; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
         
}
