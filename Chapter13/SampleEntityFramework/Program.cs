using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {

            #region
            //InsertBooks ();
            //AddAuthors ();
            //AddBooks ();
            //UpdateBook ( "銀河鉄道の夜" );
            //DisplayAllBooks ();
            //DeleteBook ();

            //foreach (var book in GetBooks ( "夏目" )) {
            //    Console.WriteLine ( $"{book.Title}:{book.Author.Name}" );
            //}

            

            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write ( sql ); };

                var count = db.Books.Count ();
                Console.WriteLine ( count );
            }

            #endregion


            Console.WriteLine ( "データを挿入しました。続けるにはEnterキーを押してください" );
            Console.ReadLine ();
            Console.WriteLine ();


        }

        // List 13-5
        static void InsertBooks() {
            using (var db = new BooksDbContext ()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime ( 1867, 2, 9 ),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add ( book1 );
                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime ( 1909, 6, 19 ),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add ( book2 );
                db.SaveChanges ();
                //Console.WriteLine ($"{book1.Id}:{book2.Id}");
                
            }
        }

        //List13-7 LINQ to Entities
        static IEnumerable<Book> GetBooks(string str) {
            using (var db = new BooksDbContext ()) {
                return db.Books.Where ( x => x.PublishedYear >= 1900 ).Include ( nameof ( Author ) ).ToList ();
            }
        }

        //13-8
        static void DisplayAllBooks() {
            var books = GetBooks ("夏目");
            foreach (var book in books) {
                Console.WriteLine ( $"{book.Title}{book.PublishedYear}" );
            }

        }

        //13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime ( 1878, 12, 7 ),
                    Gender = "F",
                    Name = "与謝野晶子",
                };
                db.Authors.Add ( author1 );

                var author2 = new Author {
                    Birthday = new DateTime ( 1896, 8 , 27),
                    Gender = "M",
                    Name = "宮沢賢治",
                };
                db.Authors.Add ( author2 );
                db.SaveChanges ();
            }
        }

        //13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.First ( a => a.Name == "与謝野晶子" );
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add ( book1 );
                
                var author2 = db.Authors.First ( a => a.Name == "宮沢賢治" );
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add ( book2 );

                db.SaveChanges ();
            }
        }

        //13-11
        private static void UpdateBook(string title) {
            using (var db = new  BooksDbContext()) {
                var book = db.Books.First ( b => b.Title == title);
                book.PublishedYear = 2016;
                db.SaveChanges ();
            }
        }
        //13-12
        private static void DeleteBook() {
            using (var db = new BooksDbContext ()) {
                var book = db.Books.SingleOrDefault ( x => x.Id == 45 );
                if (book != null) {
                    db.Books.Remove ( book );
                    db.SaveChanges ();
                }
            }
        }

    }
}
