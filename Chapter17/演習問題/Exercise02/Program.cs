using Exercise02.ConcreteConverter;
using Exercise02.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            while (true) {
                var from = GetConverterBase ( "変換元の単位を入力してください" );
                var to = GetConverterBase ( "変換先の単位を入力してください" );

                var distance = GetDistance ( from );
                var converter = new DistanceConverter ( from, to );

                var result = converter.Convert ( distance );
                Console.WriteLine ( $"{distance}{from.UnitName}は、{result:0.000}{to.UnitName}です\n" );
                Console.WriteLine ( "Enterで再開" );
                Console.ReadLine ();
            }
        }

        static double GetDistance(ConverterBase from) {
            double? valueX = null;
            do {
                Console.WriteLine ( $"変換したい距離（単位:{from.UnitName}を入力してください =>" );

                var line = Console.ReadLine ();
                double temp;
                valueX = double.TryParse ( line, out temp ) ? (double?)temp : null;
            } while (valueX == null);
            return valueX.Value;
        }

        static ConverterBase GetConverterBase(string msg) {
            ConverterBase converter = null;
            do {
                Console.WriteLine ( msg + "=> " );
                var unit = Console.ReadLine ();
                converter = ConverterFactory.GetInstance ( unit );
            } while (converter == null);
            return converter;
        }
    }
}
