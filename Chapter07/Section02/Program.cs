using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {

        static Dictionary<string, List<CityInfo>> cityDict = new Dictionary<string, List<CityInfo>>();

        static void Main(string[] args) {

            input();

            Console.Write("1:一覧表示 2:県名指定 :");
            string num = Console.ReadLine();
            if (num == "1") {
                showAll();
            }
            else if (num == "2") {
                showOne();
            }

            Console.WriteLine("*****終了*****");
        }

        public static void input() {

            
            string prefectureName, cityName;
            int population;

        

            while (true) {
                Console.Write("県名：");
                prefectureName = Console.ReadLine();


                if (prefectureName == "999") {
                    break;
                }

                Console.Write("市町村：");
                cityName = Console.ReadLine();
                Console.Write("人口:");
                population = int.Parse(Console.ReadLine());

                

                //県名が未登録
                if (!cityDict.ContainsKey(prefectureName)) {
                    cityDict.Add(prefectureName, new List<CityInfo>());
                }



                if (cityDict[prefectureName].Any(ci => ci.CityName == cityName)) {
                    Console.WriteLine("既に同じ県名、市町村名が登録されています");
                    Console.WriteLine("上書きしますか y/n:");

                    if (Console.ReadLine() == "y") {
                        cityDict[prefectureName].Find(x => x.CityName == cityName).Population = population;
                        

                    }else {
                        continue;
                    }

                }else {
                    cityDict[prefectureName].Add(new CityInfo {
                        CityName = cityName,
                        Population = population,
                    });
                }

                

            }
        }


        public static void showAll() {

            foreach (var item in cityDict.OrderBy(x => x.Key)) {
                foreach (var item2 in item.Value.OrderBy(x => x.Population)) {
                    Console.WriteLine("{0}({1}) : {2:#,0}人", item.Key, item2.CityName, item2.Population);
                }
            }
        }
        
        public static void showOne() {
            string searchedName;

            Console.Write("県名を入力:");
            searchedName = Console.ReadLine();

            if (cityDict.ContainsKey(searchedName)) {
                foreach (var item in cityDict[searchedName].OrderBy(ci => ci.CityName)) {
                    Console.WriteLine("{0}({1}) : {2:#,0}人", searchedName, item.CityName, item.Population);
                }
            }
            else {
                Console.WriteLine("そのような県名のデータはありません。");
                Console.WriteLine();
                
            }
        }

    }

    class CityInfo {
        public string CityName{ get; set; }
        public int Population{ get; set; }
    }
        
        
}