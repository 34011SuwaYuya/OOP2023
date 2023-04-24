using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BallApp {
    class TennisBall:Obj {

        Random rdm = new Random();
        public TennisBall(double pointX, double pointY) {
            while (MoveX == 0)
            {
                MoveX = rdm.Next(-50, 50);
            }

            while (MoveY == 0)
            {
                MoveY = rdm.Next(-50, 50);
            }

            PosX = pointX;
            PosY = pointY;

            Image = Image.FromFile(@"pic\tennis_ball.png");
            Count++;
        }
    }
}
