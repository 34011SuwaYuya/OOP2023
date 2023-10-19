using Exercise01.TextFileProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise01 {
    class ToHankakuProcessor : TextProcessor {
        //全角半角変換用ディクショナリ
        private static Dictionary<char, char> _dictionary = new Dictionary<char, char> {
            {'０','0'},{'１','1'},{'２','2'},{'３','3'},{'４','4'},{'５','5'},{'６','6'},{'７','7'},{'８','8'},{'９','9'},
        };


        protected override void Initialize(string fname) {
        }


        protected override void Execute(string line) {
            //line = line.Replace ( "１", "1" ).Replace ( "２", "2" ).Replace ( "３", "3" ).Replace ( "４", "4" ).Replace ( "５", "5" ).Replace ( "６", "6" ).Replace ( "７", "7" ).Replace ( "８", "8" ).Replace ( "９", "9" ).Replace ( "０", "0" );
            line = Regex.Replace ( line, "[０-９]", p => ( (char)( p.Value[0] - '０' + '0' ) ).ToString () );
            Console.WriteLine ( line );

            //foreach (var item in _dictionary) {
            //    line = Regex.Replace ( line, item.Key.ToString (), item.Value.ToString () );
            //}
            //Console.WriteLine ( line );

            //line = Regex.Replace ( line, "[0-9]", c => _dictionary[c.Value[0]].ToString () );

        }


        protected override void Terminate() {
        }
    }
}
