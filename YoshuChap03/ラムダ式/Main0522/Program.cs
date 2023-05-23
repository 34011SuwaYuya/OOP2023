using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main0522 {
    class Program {
        static void Main(string[] args) {

            var numbers = new int[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, };
        }

        public int Count(int[] numbers, Predicate<int> judge) {
            int count = 0;

            foreach (var n in numbers) {
                if (judge(n)) {
                    count++;
                }
            }

            return count;
        }

    }
}
