using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall :Ball {
        private static int count;  //Staticにしないと参照できない(インスタンス変数しか取得できない)

        public SoccerBall(double xp, double yp) : base(xp, yp, @"pic\soccer_ball.png"){
            


            base.defaultMoveConfig();
            Count++;
        }

        public static int Count { get => count; set => count = value; }

        public override void Move() {    //外部からアクセスするものは大文字にすることが多い

            if (PosY > 520 || PosY < 0)
            {
                MoveY = -MoveY;
            }
            if (PosX > 730 || PosX < 0)
            {
                MoveX = -MoveX;
            }

            PosX += MoveX;
            PosY += MoveY;
        }

       
    }
}
