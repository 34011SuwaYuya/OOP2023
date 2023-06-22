using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static Dictionary<string, string> _prefctures;

        static void Main(string[] args) {

            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            //flowerDict["morning glory"] = 250;

            //Console.WriteLine("ヒマワリの価格は{0}円です。" , flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です。", flowerDict["tulip"]);

            //Console.WriteLine("あさがおの価格は{0}円です。", flowerDict["morning glory"]);


            //県庁所在地の登録
            //キーボードで入力
            string prefecture , city;
            _prefctures = new Dictionary<string, string>();

            
            while (true) {
                Console.Write("県名：");
                prefecture = Console.ReadLine();


                if (_prefctures.ContainsKey(prefecture)) {
                    Console.WriteLine("既に登録済みです。");
                    continue;
                }else if (prefecture == "999") {
                    break;
                }

                Console.Write("所在地：");
                city = Console.ReadLine();

                _prefctures[prefecture] = city;
            }



            Console.Write("1:一覧表示 2:県名指定");
            string num = Console.ReadLine();
            if (num == "1") {
                showAll();
            }
            else if(num == "2") {
                showOne();
            }
        }

        public static void showAll() {
            foreach (var item in _prefctures) {
                Console.WriteLine("{0}({1})", item.Key, item.Value);
            }
        }

        public static void showOne() {
            string searchedName;

            Console.Write("県名を入力:");
            searchedName = Console.ReadLine();

            if (_prefctures.ContainsKey(searchedName)) {
                Console.WriteLine(_prefctures[searchedName] + "です");
            }
            else {
                Console.WriteLine("そのような県名のデータはありません。");
            }
        }

    }

    class CityInfo {
        public string City{ get; set; }
        public int Population{ get; set; }
    }

}
