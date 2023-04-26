using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    abstract class Ball :Obj{

        private double moveX; //移動量(x方向)
        private double moveY;
        public Ball(double xp, double yp, string path): base(xp, yp, path) {
        }


        Random rdm = new Random();
        //メソッド
        public abstract void Move(PictureBox pbBar, PictureBox bpBall);

        public void defaultMoveConfig() {
            while (MoveX == 0)
            {
                MoveX = rdm.Next(-20, 20);
            }

            while (MoveY == 0)
            {
                MoveY = rdm.Next(-20, 20);
            }
        }

        public override void Move(Keys direction) {
            ;
        }

        public double MoveY { get => moveY; set => moveY = value; }
        public double MoveX { get => moveX; set => moveX = value; }
    }
}
