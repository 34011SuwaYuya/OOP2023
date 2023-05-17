using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {



            var songs = new Song[] {
                new Song("Let it be", "The Beatles", 243),
                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
                new Song("Close To You", "Carpenters", 276),
                new Song("Honesty", "Billy Joel", 231),
                new Song("I Will Always Love You", "Whitney Houston", 273),
            };


            var lists = new List<Song>();
            lists.Add(new Song("Let it be", "The Beatles", 243));
            lists.Add(new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293));
            lists.Add(new Song("Close To You", "Carpenters", 276));
            lists.Add(new Song("Honesty", "Billy Joel", 231));
            lists.Add(new Song("I Will Always Love You", "Whitney Houston", 273));

            /* いちいち配列やリストをメインメソッドで呼び出す場合
            //配列を使うパターン
            foreach (Song song in songs) {
                //Mainメソッド内で表示する働きをさせる場合
                Console.WriteLine("タイトル：{0}  アーティスト:{1}  時間:{2:00}:{3:00}", song.Title, song.ArtistName, song.Minutes, song.Seconds);
            }

            //リストを使うパターン
            foreach (var theSong in lists) {
                //Songクラス内に表示するメソッドを作成した場合
                theSong.PrintSongData();
                //Console.WriteLine(theSong.passSongData()); うまくいかない
            }
            */

            PrintSongs(lists);
            PrintSongs(songs);
        }

        public static void PrintSongs(IEnumerable<Song> songs) {
            
            
            foreach (var song in songs) {
                //song.PrintSongData();
                Console.WriteLine("{0}, {1}, {2:m\\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
            
                
            

        }
    }
}
