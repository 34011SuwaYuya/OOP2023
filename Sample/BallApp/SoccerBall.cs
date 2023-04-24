using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall :Obj {

        private double moveX; //移動量(x方向)
        private double moveY;

        Random rdm = new Random();

        public SoccerBall(double xp, double yp):base(xp,yp, @"pic\soccer_ball.png")

            {
            while (MoveX == 0)
            {
                MoveX = rdm.Next(-50, 50);
            }
            
            while (MoveY == 0)
            {
                MoveY = rdm.Next(-50, 50);
            }
            Count++;
        }

        public double MoveY1 { get => MoveY; set => MoveY = value; }
        public double MoveX1 { get => MoveX; set => MoveX = value; }
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }

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
