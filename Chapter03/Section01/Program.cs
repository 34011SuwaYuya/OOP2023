﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {



        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6,};
           
            int count = numbers.Count( n => n % 5 == 0 && n > 0);
            int sum = numbers.Sum();

            var evenSum = numbers.Where(n => n % 2 == 1).Sum();
            //sum = evenNums.Sum();

            Console.WriteLine(count);
            Console.WriteLine(evenSum);


        }

    }
}
