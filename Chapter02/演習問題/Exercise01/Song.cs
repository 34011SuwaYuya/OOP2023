using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Song {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        //Lengthを元に分と秒を計算
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Song(string title, string artistname, int length) {
            Title = title;
            ArtistName = artistname;
            Length = length;
            SetLength();

        }

        private void SetLength() {
            Minutes = Length / 60;
            Seconds = Length % 60;

        }

        public void PrintSongData() {
            //Console.WriteLine("タイトル：{0}  アーティスト:{1}  時間:{2:00}:{3:00}", Title, ArtistName, Minutes, Seconds);
            //TimeSpan構造体を使うと楽に時間分秒が計算できる
            
            Console.WriteLine("{0}, {1}, {2:m\\:ss}", Title, ArtistName, TimeSpan.FromSeconds(Length));
            
        }

        

    }
}
