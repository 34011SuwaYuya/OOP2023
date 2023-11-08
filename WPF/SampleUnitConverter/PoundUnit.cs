using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    class PoundUnit : WeightUnit {

        private static List<PoundUnit> units = new List<PoundUnit> {
            new PoundUnit {Name = "oz", Coefficient = 1},
            new PoundUnit {Name = "lb", Coefficient = 1 * 16 },
            new PoundUnit {Name = "st", Coefficient = 1 * 16 * 14},
        };

        public static ICollection<PoundUnit> Units { get { return units; } }


        public double FromGramUnit(GramUnit unit, double value) {
            return ( value * unit.Coefficient ) / 28349.54 / this.Coefficient;
        }
    }
}
