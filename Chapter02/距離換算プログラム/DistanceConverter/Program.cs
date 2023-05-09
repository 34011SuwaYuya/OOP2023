using System;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            //フィートからメートルへの対応表を出力
            for (int feet = 1 ; feet <= 10; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0}ft = {1:0.0}m", feet, meter);
            }

        }

        //フィートからメートルを求める　繰返し利用するために
        static double FeetToMeter(int feet) {      //シグネチャ
            return feet * 0.3048;
        }
    }
}
