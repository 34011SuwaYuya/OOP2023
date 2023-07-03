using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var tw = new TimeWatch();

            Console.WriteLine("スタート？");
            Console.ReadLine();

            tw.Start();


            //Thread.Sleep(1000);


            Console.WriteLine("ストップ？");
            Console.ReadLine();

            TimeSpan duration = tw.Stop();
            Console.WriteLine("処理時間は{0}ミリ秒でした", duration.TotalSeconds);

        }
    }

    class TimeWatch {
        private DateTime _dateTime;

        public void Start() {
            _dateTime = DateTime.Now;
        }

        public TimeSpan Stop() {

            return DateTime.Now - _dateTime;
        }
    }
}
