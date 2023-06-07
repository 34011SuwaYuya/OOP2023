#define NonArray
//#define ArrayOrList

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {



            Stopwatch sw = new Stopwatch();
            sw.Start();
#if NonArray

            var number = Enumerable.Range(1, 1_000_000);
            WriteTotalMemory("配列確保後");

            var evenNums = number.Where(x => x % 2 == 0);
            var average = evenNums.Average();
            Console.WriteLine(average);
            WriteTotalMemory("偶数抽出後");

#elif ArrayOrList

            var number = Enumerable.Range(1, 1_000_000).ToList();
            WriteTotalMemory("配列確保後");

            var evenNums = number.Where(x => x % 2 == 0).ToList();
            var average = evenNums.Average();
            Console.WriteLine(average);
            WriteTotalMemory("偶数抽出後");
#endif
            Console.WriteLine("実行時間　＝　{0}", sw.Elapsed.ToString(@"ss\.ffff"));

        }

        static void WriteTotalMemory(string header) {
            var totalMemory = GC.GetTotalMemory(true) / 1024.0 / 1024.0;
            Console.WriteLine($"{header}: {totalMemory:0.000 MB}");
        }
    }
}
