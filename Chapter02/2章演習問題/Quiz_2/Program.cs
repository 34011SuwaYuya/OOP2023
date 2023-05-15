using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_2 {
    class Program {
        static void Main(string[] args) {

            Song[] songs = new Song[3];
            Song s1 = new Song("M87", "米津玄師", 181);
            Song s2 = new Song("ペールブルー", "米津玄師", 335);
            Song s3 = new Song("糸", "中島みゆき", 245);

            songs[0] = s1;
            songs[1] = s2;
            songs[2] = s3;
            Console.WriteLine("1");
            foreach (Song song in songs) {
                Console.WriteLine(song);
            }

        }
    }
}
