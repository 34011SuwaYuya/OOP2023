using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    //フィートとメートルの単位変換クラス
    public static class InchConverter {
        private const double ratio = 0.0254;

        

        //インチからメートルを求める
        public static double InchToMeter(double inch) {
            return ratio * inch;
        }

        //メートルからインチを求める
        public static double MeterToInch(double meter) {
            return meter / ratio;
        }



    }
}
