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

            var text = File.ReadAllLines ( "sample.html" );
            foreach (var txt in text) {
                Console.WriteLine ( txt );
            }
        }

        private static void TagLower(string file) {

            var lines = File.ReadLines ( file );
            var sb = new StringBuilder ();



            #region オリジナル回答、不正解

            //var pattern = @"<[^<>]+>";
            //foreach (var line in lines) {
            //    string replaced = line;
            //    var matches = Regex.Matches ( line, pattern );

            //    foreach (Match match in matches) {
            //        replaced = Regex.Replace ( replaced, match.Value, match.Value.ToLower () );
            //    }
            //    sb.AppendLine ( replaced );
            //}
            #endregion



            foreach (var line in lines) {
                var s = Regex.Replace ( line,
                    @"<(/?)([A-Z][A-Z0-9]*)(.*?)>",
                    m => {
                        return string.Format ( "<{0}{1}{2}>", m.Groups[1].Value, m.Groups[2].Value.ToLower (), m.Groups[3].Value );
                } );
                sb.AppendLine ( s );
            }

            //ファイル出力
            File.WriteAllText ( file, sb.ToString () );


            
        }
    }
}
