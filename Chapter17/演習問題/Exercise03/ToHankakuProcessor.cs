using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise03 {
    class ToHankakuProcessor : ITextFileService {
        //全角半角変換用ディクショナリ
        private static Dictionary<char, char> _dictionary = new Dictionary<char, char> {
            {'０','0'},{'１','1'},{'２','2'},{'３','3'},{'４','4'},{'５','5'},{'６','6'},{'７','7'},{'８','8'},{'９','9'},
        };

        public void Initialize(string fname) {
        }

        void ITextFileService.Execute(string line) {
            foreach (var item in _dictionary) {
                line = Regex.Replace ( line, item.Key.ToString (), item.Value.ToString () );
            }
            Console.WriteLine ( line );
        }

        public void Terminate() {
        }


    }
}
