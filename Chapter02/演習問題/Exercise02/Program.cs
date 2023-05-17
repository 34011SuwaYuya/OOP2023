using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            if (args.Length >= 1 && args[0] == "-tom") {

                if(args.Length >= 3 ) {
                    InchToMeter(int.Parse(args[1]), int.Parse(args[2]));
                    
                }else {
                    InchToMeter(1, 10);
                }
                
            }
            else if (args.Length >= 1 && args[0] == "-toi") {
                if (args.Length >= 3) {
                    MeterToInch(int.Parse(args[1]), int.Parse(args[2]));
                }else {
                    MeterToInch(1, 10);
                }
            }
            else {

            }
        }

        private static void InchToMeter(int start, int stop) {

            //フィートからメートルへの対応表を出力
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.InchToMeter(inch);
                Console.WriteLine("{0} inch = {1:0.0000}m", inch, meter);
            }
        }

        private static void MeterToInch(int start, int stop) {

            //メートルからフィートへの対応表を出力

            for (int meter = start; meter <= stop; meter++) {
                double inch = InchConverter.MeterToInch(meter);
                Console.WriteLine("{0} m = {1:0.0000}inch", meter, inch);
            }
        }
    }
    
}
