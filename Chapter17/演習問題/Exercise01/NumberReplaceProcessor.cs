using Exercise01.TextFileProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class NumberReplaceProcessor : TextProcessor {

        protected override void Initialize(string fname) {
        }


        protected override void Execute(string line) {
            line = line.Replace ( "１", "1" ).Replace ( "２", "2" ).Replace ( "３", "3" ).Replace ( "４", "4" ).Replace ( "５", "5" ).Replace ( "６", "6" ).Replace ( "７", "7" ).Replace ( "８", "8" ).Replace ( "９", "9" ).Replace ( "０", "0" );
            Console.WriteLine ( line );
        }


        protected override void Terminate() {
        }
    }
}
