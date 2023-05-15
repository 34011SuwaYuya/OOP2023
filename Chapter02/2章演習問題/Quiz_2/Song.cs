using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Quiz_2 {
    class Song {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }
        public string lengthMinutes= "";

        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
            SetLengthMinutes();
        }

        private void SetLengthMinutes() {
            string min = "" + Length / 60;
            string num = "[0-9]{1}";
            
            if (Regex.IsMatch(min, ".")) {
                //一桁分なら0を頭に追加
                min = "0" + min;
            }

            string sec =Length % 60 + "";

            if (Regex.IsMatch(sec, ".")) {
                //一桁分なら0を頭に追加
                sec = "0" + sec;
            }

            lengthMinutes = min + ": " + sec;
        }
        public string GetLengthMinutes() {
            SetLengthMinutes();
            return lengthMinutes;
        }


        
        public override string ToString() {
            return this.Title + " " + this.ArtistName+ " " + this.GetLengthMinutes();
        }
    }
}
