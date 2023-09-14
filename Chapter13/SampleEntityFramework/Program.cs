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

            //InsertBooks ();
            //AddAuthors ();

            #region 前提のデータの追加
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

                var yosano = new Author {
                    Birthday = new DateTime ( 1878, 12, 7 ),
                    Gender = "F",
                    Name = "与謝野晶子",
                };
                db.Authors.Add ( yosano );

                var author2 = new Author {
                    Birthday = new DateTime ( 1896, 8, 27 ),
                    Gender = "M",
                    Name = "宮沢賢治",
                };
                db.Authors.Add ( author2 );
                db.SaveChanges ();

                var author1 = db.Authors.First ( a => a.Name == "与謝野晶子" );
                var book3 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = yosano,
                };
                db.Books.Add ( book3 );

                var miyazawa = db.Authors.First ( a => a.Name == "宮沢賢治" );
                var book4 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add ( book4 );

                db.SaveChanges ();
            }
            #endregion


            Console.WriteLine ( "# 1.1" );
            Exercise1_1 ();

            Console.WriteLine ();
            Console.WriteLine ( "# 1.2" );
            Exercise1_2 ();

            Console.WriteLine ();
            Console.WriteLine ( "# 1.3" );
            Exercise1_3 ();

            Console.WriteLine ();
            Console.WriteLine ( "# 1.4" );
            Exercise1_4 ();

            Console.WriteLine ();
            Console.WriteLine ( "# 1.5" );
            Exercise1_5 ();


            Console.WriteLine ( "データを挿入しました。続けるにはEnterキーを押してください" );
            Console.ReadLine ();
            Console.WriteLine ();


        }

        private static void Exercise1_1() {
            using (var db = new BooksDbContext ()) {

                //Author追加
                var author1 = new Author {
                    Birthday = new DateTime ( 1888, 12, 26 ),
                    Gender = "M",
                    Name = "菊池寛",
                };
                db.Authors.Add ( author1 );

                var author2 = new Author {
                    Birthday = new DateTime ( 1899, 6, 14 ),
                    Gender = "M",
                    Name = "川端康成",
                };
                db.Authors.Add ( author2 );
                db.SaveChanges ();


                //Book追加
                var natsume = db.Authors.First ( a => a.Name == "夏目漱石" );
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = natsume,
                };
                db.Books.Add ( book1 );

                var kawabata = db.Authors.First ( a => a.Name == "川端康成" );
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = kawabata,
                };
                db.Books.Add ( book2 );

                var kikuchi = db.Authors.First ( a => a.Name == "菊池寛" );
                var book3 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = kikuchi,
                };
                db.Books.Add ( book3 );

                var miyazawa = db.Authors.First ( a => a.Name == "宮沢賢治" );
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = miyazawa,
                };
                db.Books.Add ( book4 );

                db.SaveChanges ();

            }

        }

        private static void Exercise1_2() {
            using (var db = new BooksDbContext()) {
                foreach (var book in db.Books.Include ( nameof ( Author ) ).ToList ()) {
                    Console.WriteLine ( $"{book.Title}:{book.PublishedYear}:{book.Author.Name}" );
                }
            }
        }

        private static void Exercise1_3() {
            using (var db = new BooksDbContext()) {
                int maxLength = db.Books.Max ( b => b.Title.Length );   //タイトルの長さの最大値
                foreach (var book in db.Books.Where ( b => b.Title.Length >= maxLength )) {
                    Console.WriteLine ( $"{book.Title}" );
                }

            }


        }

        private static void Exercise1_4() {
            using (var db = new BooksDbContext ()) {
                var orderedByPublishedyear= db.Books.Include(nameof( Author)).OrderBy( b => b.PublishedYear).ToList ();//古い順で並び替え

                foreach (var book in orderedByPublishedyear.Take(3)) {
                    Console.WriteLine ( $"{book.Title}:{book.Author.Name}" );
                }
            }
        }

        private static void Exercise1_5() {
            using (var db = new BooksDbContext()) {
                var orderedAuthors = db.Authors.OrderByDescending ( a => a.Birthday ).ToList();

                foreach (var author in orderedAuthors) {

                    var author_books = db.Books.Where ( b => b.Author.Name == author.Name ).ToList();

                    foreach (var book in author_books) {
                        Console.WriteLine ($"{author.Name}:{book.Title}");
                    }
                    Console.WriteLine ( "=================" );
                }
            }
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
