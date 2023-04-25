using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BallApp {
    class TennisBall:Obj {

        
        public TennisBall(double xp, double yp) : base(xp, yp, @"pic\tennis_ball.png") {
            base.defaultMoveConfig();
            Count++;
        }


        public override void Move() {
            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }

            if (PosY > 520 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            PosX += MoveX;
            PosY += MoveY;
        }
    }
}
