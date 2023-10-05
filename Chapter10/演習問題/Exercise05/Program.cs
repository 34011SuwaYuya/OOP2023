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

            foreach (string line in lines) {

                var matches = Regex.Matches ( line, @"<([^<>]+)>" );
                foreach (Match match in matches) {
                    line = Regex.Replace ( line, match.Value, match.Value.ToLower () );
                }

            }





            //ファイル出力
            File.WriteAllText(file, sb.ToString());
        }
    }
}
