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
        public int Minutes { get; set; }
        public int Seconds {get; set;}

        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
            SetLength();
            
        }

        private void SetLength() {
            Minutes = Length / 60;
            Seconds = Length % 60;
            
        }
        

        
        public override string ToString() {
            return this.Title + " " + this.ArtistName+ " " + Length;
        }
    }
}
