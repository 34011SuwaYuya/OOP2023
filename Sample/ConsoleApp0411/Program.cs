using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("入力する数を入れる：");
            int count = int.Parse(Console.ReadLine());

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int j = 0; j < count; j++)
            {

                for (int k = 0; k < count - j - 1; k++)
                {
                    Console.Write("B");
                }
                for (int i = 0; i < j + 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int m = 0; m < count; m++)
            {
                for (int i = 0; i < count - m-1; i++)
                {
                    Console.Write("B");
                }
                for (int k = 0; k < m + 1; k++)
                {
                    Console.Write("＊");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i <  j ; i++)
                {
                    Console.Write("_");
                }
                for (int k = 0; k < count - j ; k++)
                {
                    Console.Write("＊");
                }

                Console.WriteLine();
            }
        }
    }
}
