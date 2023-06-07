using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {


            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        private static void Exercise1_1(int[] numbers) {
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers) {
            foreach (var item in numbers.Skip(numbers.Length -2)) {
                Console.WriteLine(item);
            }
            
        }

        private static void Exercise1_3(int[] numbers) {
            
            var stringArray = numbers.Select(x => x.ToString());
            foreach (var item in stringArray) {
                Console.WriteLine(item);
            }

        }

        private static void Exercise1_4(int[] numbers) {
            var sortedNums = numbers.OrderBy(x => x).Take(3);
            foreach (var item in sortedNums) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var answerNum = numbers.Distinct().Count(x => x > 10);
            Console.WriteLine(answerNum);
        }
    }
}
