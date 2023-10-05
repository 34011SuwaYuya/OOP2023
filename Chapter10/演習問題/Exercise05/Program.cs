using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise05 {
    class Program {
        static void Main(string[] args) {
            TagLower("sample.html");
        }

        private static void TagLower(string file) {
            var lines = File.ReadLines(file);
            var sb = new StringBuilder();

            string thisLine;
            foreach (string line in lines) {
                thisLine = line;
                
                var matches = Regex.Matches ( line, @"<[^<>]+>" );
                foreach (var item in matches) {
                    Console.WriteLine ( item.ToString().ToLower() );
                }
                Console.WriteLine(@"---------------------------");


                //foreach (Match match in matches) {
                //    thisLine = Regex.Replace ( line,  match.Value, match.Value.ToLower());
                //}
                //sb.AppendLine ( thisLine );
            }


            //Console.WriteLine ( sb.ToString () );


            //ファイル出力
            //File.WriteAllText ( file, sb.ToString () );
        }
    }
}
