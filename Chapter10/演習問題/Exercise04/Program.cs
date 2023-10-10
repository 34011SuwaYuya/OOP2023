﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        static void Main(string[] args) {

            var lines = File.ReadAllLines("sample.txt");
            //オリジナルの回答
            var pattern = @"[Vv]ersion\s*=\s*""v4.0""";

            for (int i = 0; i < lines.Length; i++) {
                var replaced = Regex.Replace ( lines[i], pattern, @"version=""v5.0" );
                lines[i] = replaced;
            }
            File.WriteAllLines ( "sample.txt", lines );

            //模範解答
            //var newlines = lines.Select ( s => Regex.Replace ( s, @"\b(v|V)ersion\s*=\s*""v4\.0""", @"version=""v5.0" ) );
            //File.WriteAllLines ( "sample.txt", newlines );



            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}
