using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine ( "1-2" );
            Exercise1_2 ();
            Console.WriteLine ();
            Console.WriteLine ( "1-3" );
            Exercise1_3 ();
            Console.WriteLine ();
            Console.WriteLine ( "1-4" );
            Exercise1_4 ();
            Console.WriteLine ();
            Console.WriteLine ( "1-5" );
            Exercise1_5 ();
            Console.WriteLine ();
            Console.WriteLine ( "1-6" );
            Exercise1_6 ();
            Console.WriteLine ();
            Console.WriteLine ( "1-7" );
            Exercise1_7 ();
            Console.WriteLine ();
            Console.WriteLine ( "1-8" );
            Exercise1_8 ();
            Console.WriteLine ();

            Console.ReadLine ();
        }

        private static void Exercise1_2() {
            var maxPrice = Library.Books.Max ( b => b.Price );
            var maxBooks = Library.Books.Where ( b => b.Price == maxPrice );
            foreach (Book item in maxBooks) {
                Console.WriteLine ( item);
            }
            
        }

        private static void Exercise1_3() {
            var group = Library.Books.GroupBy ( b => b.PublishedYear ).OrderBy(g => g.Key);
            foreach (var yearGroup in group) {
                Console.WriteLine ("{0}年：{1}冊", yearGroup.Key, yearGroup.Count());
            }


            //模範解答
            //var query = Library.Books.GroupBy ( b => b.PublishedYear ).Select ( g => new { PublishedYear = g.Key, Count = g.Count () } ).OrderBy ( x => x.PublishedYear );
            //foreach (var item in query) {
            //    Console.WriteLine ( "{0}年：{1}冊", item.PublishedYear, item.Count );
            //}

        }

        private static void Exercise1_4() {
            //自力回答 JOINせずに毎回カテゴリーを探す
            var ordered = Library.Books.OrderByDescending ( b => b.PublishedYear ).ThenByDescending ( b => b.Price );
            foreach (var book in ordered) {
                Console.WriteLine ( $"{book.PublishedYear}年 {book.Price}円 {book.Title} ( {Library.Categories.First ( c => c.Id == book.CategoryId).Name})" );
            }


            //模範解答 先に結合させておく方式
            //var query = Library.Books.Join ( Library.Categories, book => book.CategoryId, c => c.Id,
            //   (book, category) => new {
            //       book.PublishedYear,
            //       book.Price,
            //       book.Title,
            //       CategoryName = category.Name
            //   } ).OrderByDescending(x => x.PublishedYear).ThenBy(x => x.Price);
            //foreach (var item in query) {
            //    Console.WriteLine ("{0}年{1}円{2}({3})",item.PublishedYear, item.Price, item.Title, item.CategoryName );
            //}



        }

        private static void Exercise1_5() {

            //var cID2016 = Library.Books.Where ( b => b.PublishedYear == 2016 ).Select(b => b.CategoryId).Distinct();
            //foreach (var cID in cID2016) {
            //    Console.WriteLine ( Library.Categories.First(c => c.Id == cID).Name );
            //}

            var cNames2016 = Library.Books.Where ( b => b.PublishedYear == 2016 ).Select ( b => b.CategoryId ).Distinct ().
                Join (
                Library.Categories,
                id => id,
                c => c.Id,
                (id, c) =>  c.Name  ).
                OrderBy(cn => cn);

            foreach (var cName in cNames2016) {
                Console.WriteLine ( cName);
            }

           


        }

        private static void Exercise1_6() {


            //本来はGroupByを使う必要がある　joinしてからgroupByする
            var groups = Library.Categories.GroupJoin ( Library.Books, c => c.Id, b => b.CategoryId,
                (c, books) => new { Category = c.Name, Books = books } ).OrderBy(g => g.Category);

            foreach (var group in groups) {
                Console.WriteLine ( "#" + group.Category );
                foreach (var book in group.Books) {
                    Console.WriteLine ( book.Title );
                }
            }
        }

        private static void Exercise1_7() {
            var groups = Library.Books.Where (
                b => b.CategoryId == Library.Categories.First ( c => c.Name == "Development" ).Id ).GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);
            foreach (var group in groups) {
                Console.WriteLine ( "#" + group.Key );
                foreach (var book in group) {
                    Console.WriteLine ( book.Title );
                }
            }

            //模範解答
            //var catid = Library.Categories.Single ( c => c.Name == "Development" ).Id;
            //var groups2 = Library.Books.Where ( b => b.CategoryId == catid ).GroupBy ( b => b.PublishedYear ).OrderBy ( g => g.Key );
            //foreach (var group in groups2) {
            //    Console.WriteLine ( "#{0}年", group.Key );
            //    foreach (Book book in group) {
            //        Console.WriteLine ( book.Title );
            //    }
            //}

        }

        private static void Exercise1_8() {
            var groups = Library.Categories.GroupJoin (
                Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, books) => new { Category = c.Name, Books = books } ).
                Where(gj => gj.Books.Count() >= 4);


            foreach (var catGroup in groups) {
                Console.WriteLine ( catGroup.Category );
                //各要素を表示することも可能
                //foreach (var book in catGroup.Books) {
                //    Console.WriteLine ( book );
                //}
            }
        }
    }
}
