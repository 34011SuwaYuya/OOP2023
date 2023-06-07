using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> {
                9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4,  
            };
            Console.WriteLine("リストの数値の平均" + numbers.Average());

            var books = Books.GetBooks();

            Console.WriteLine("平均金額" + books.Average(x => x.Price));
            Console.WriteLine("平均ページ数" + books.Average(x => x.Pages));
            Console.WriteLine("一番高額な本の金額" + books.Max(x => x.Price));


            var fiveHundredYenBooks = books.Where( x => x.Price >= 500).ToList();
            fiveHundredYenBooks.ForEach(x => Console.WriteLine("500円以上の本のタイトル：{0}:{1}" , x.Title, x.Price));
            books.Where(x => x.Price >= 500).ToList().ForEach(x => Console.WriteLine("{0}",x.Price));


            //1行でまとめて条件から抽出して表示する オリジナル
            //books.Where(x => x.Pages >= 300).ToList().ForEach(x => Console.WriteLine("300ページ以上:" + x.Title));


            //var priceSortedBooks = books.OrderBy(x => x.Price);
            books.OrderByDescending(x => x.Price).ToList().ForEach(x => Console.WriteLine(x.Price));

            Console.WriteLine();
            Console.WriteLine("物語をタイトルに含む");
            books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price).ToList().ForEach(x => Console.WriteLine("{0} : {1}", x.Title, x.Price));

            Console.WriteLine();
            Console.WriteLine("タイトルに「物語」という文字列が含まれている書籍の平均ページ数を出力");
            Console.WriteLine(books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages) + "ページ");

            Console.WriteLine();
            Console.WriteLine("タイトルが長い順にタイトルを出力");
            books.OrderByDescending(x => x.Title.Length).ToList().ForEach(x => Console.WriteLine(x.Title + ":" +x.Price));


            Console.WriteLine("ooo");
        }
    }
}
