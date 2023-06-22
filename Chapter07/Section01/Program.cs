using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static Dictionary<string, CityInfo> _prefectureDict;

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

            input();

            Console.Write("1:一覧表示 2:県名指定");
            string num = Console.ReadLine();
            if (num == "1") {
                showAll();
            }
            else if(num == "2") {
                showOne();
            }
        }

        public static void input() {

            _prefectureDict = new Dictionary<string, CityInfo>();
            string prefecture, city;
            int population;

            while (true) {
                Console.Write("県名：");
                prefecture = Console.ReadLine();

               
                if (_prefectureDict.ContainsKey(prefecture)) {
                    Console.WriteLine("既に県名が登録されています");
                    Console.WriteLine("上書きしますか？(y,n)");
                    if (Console.ReadLine() != "y") {
                        continue;
                    }
                }
                else if (prefecture == "999") {
                    break;
                }

                Console.Write("所在地：");
                city = Console.ReadLine();
                Console.Write("人口:");
                population = int.Parse(Console.ReadLine());


                _prefectureDict[prefecture] = new CityInfo(city, population);
            }
        }


        public static void showAll() {
            foreach (var item in _prefectureDict) {
                Console.WriteLine("{0}({1}) : {2}人", item.Key, item.Value.City, item.Value.Population);
            }
        }

        public static void showOne() {
            string searchedName;

            Console.Write("県名を入力:");
            searchedName = Console.ReadLine();

            if (_prefectureDict.ContainsKey(searchedName)) {
                Console.WriteLine($"{searchedName} : {_prefectureDict[searchedName].City} : 人口（{_prefectureDict[searchedName].Population}");
            }
            else {
                Console.WriteLine("そのような県名のデータはありません。");
            }
        }

    }
}
