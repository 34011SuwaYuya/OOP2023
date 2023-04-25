using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall :Obj {

        public SoccerBall(double xp, double yp) : base(xp, yp, @"pic\soccer_ball.png"){
            


            base.defaultMoveConfig();
            Count++;
        }

        public override void Move() {    //外部からアクセスするものは大文字にすることが多い

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
