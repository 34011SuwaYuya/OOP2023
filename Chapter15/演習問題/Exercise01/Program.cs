using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            //Console.WriteLine ("1-2" );
            //Exercise1_2 ();
            //Console.WriteLine ("1-3");
            //Exercise1_3 ();
            //Console.WriteLine ( "1-4" );
            //Exercise1_4 ();
            Console.WriteLine ( "1-5" ); 
            Exercise1_5 ();
            Console.WriteLine ( "1-6" );
            Exercise1_6 ();
            Console.WriteLine ( "1-7" );
            Exercise1_7 ();
            Console.WriteLine ( "1-8" );
            Exercise1_8 ();

            Console.ReadLine ();
        }

        private static void Exercise1_2() {
            var book = Library.Books.Max ( b => b.Price );
            Console.WriteLine ( book );
        }

        private static void Exercise1_3() {
            var group = Library.Books.GroupBy ( b => b.PublishedYear );
            foreach (var yearGroup in group) {
                Console.WriteLine ("{0}年：{1}冊", yearGroup.Key, yearGroup.Count());
            }
        }

        private static void Exercise1_4() {
            var ordered = Library.Books.OrderByDescending ( b => b.PublishedYear ).ThenByDescending ( b => b.Price );

            foreach (var book in ordered) {
                Console.WriteLine ( $"{book.PublishedYear}年 {book.Price}円 {book.Title} ( {Library.Categories.First ( c => c.Id == book.CategoryId).Name})" );
            }

        }

        private static void Exercise1_5() {
            //var categories2016= Library.Categories.Where(c => c.Id == Library.Books.Where(b => b.PublishedYear == 2016))

        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
