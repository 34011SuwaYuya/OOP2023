using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class Bar : Obj {

        public Bar(double xp, double yp):base(double.Epsilon, yp, @"") {

        }

        public override void Move() {
            throw new NotImplementedException();
        }
    }
}
