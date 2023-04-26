using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall:Ball {
        private static int count;

        public TennisBall(double xp, double yp) : base(xp, yp, @"pic\tennis_ball.png") {
            base.defaultMoveConfig();
            Count++;
        }

        public static int Count { get => count; set => count = value; }

        public override void Move() {
            if (PosY > 520 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            if ((PosX > 730 || PosX < 0))
            {
                MoveX = -MoveX;
            }

            
            PosX += MoveX;
            PosY += MoveY;
        }

    }
}
