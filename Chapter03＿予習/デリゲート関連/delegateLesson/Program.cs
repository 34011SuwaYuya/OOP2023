﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateLesson {
    class Program {
        public delegate bool Judgement(int value);

        static void Main(string[] args) {
            
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, };
            //Judgement judge = IsEven;
            //var count = Count(numbers, judge);
            var count = Count(numbers, delegate (int n) { return n % 2 == 0; });
            Console.WriteLine(count);
            

        }


        public static int Count(int[] numbers, Judgement judge) {
            int count = 0;
            foreach (var n in numbers) {
                if (judge(n) == true) {
                    count++;
                }
            }
            return count;
        }

        public static bool IsEven(int n) {
            return (n % 2) == 0;
        }
    }
}
