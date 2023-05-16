using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートルの単位変換クラス
    public static class FeetConverter {
        private const double ratio = 0.3048;
        private const double inchRatio = 0.0254;

        //メートルからフィートを求める
        public static double FromMeter(double meter) {
            return meter / ratio;
        }

        //フィートからメートルを求める
        public static double ToMeter(double feet) {
            return feet * ratio;
        }

        //フィートからメートルを求める
        public static double InchToMeter(double inch) {
            return inchRatio * inch;
        }

    }
}
