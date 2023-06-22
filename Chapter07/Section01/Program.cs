using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
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
            
            Dictionary<string, string> prefectureList = makeDict();

            string searchedName;

            
            while (true) {
                Console.Write("県名を入力:");
                searchedName = Console.ReadLine();

                if (prefectureList.ContainsKey(searchedName)) {
                    Console.WriteLine(prefectureList[searchedName] + "です");
                }
                else if (searchedName == "000") {
                    Console.WriteLine("終了します");
                    break;
                }else {
                    Console.WriteLine("そのような県名のデータはありません。");
                }

            }

        }

        private static Dictionary<string, string> makeDict() {
            var prefectureList = new Dictionary<string, string>();
            string prefecture, city;

            while (true) {
                Console.Write("県名：");
                prefecture = Console.ReadLine();


                if (prefectureList.ContainsKey(prefecture)) {
                    Console.WriteLine("既に登録済みです。");
                    continue;
                }
                else if (prefecture == "999") {
                    break;
                }

                Console.Write("所在地：");
                city = Console.ReadLine();

                prefectureList[prefecture] = city;
            }

            return prefectureList;
        }

    }
}
