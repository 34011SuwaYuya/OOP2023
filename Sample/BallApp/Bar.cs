using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {
        private int MoveX;

        public Bar(double xp):base(xp, 520, @"pic\bar.png") {
            
        }

        public int MoveX1 { get => MoveX; set => MoveX = value; }

        public  void Move(Keys direction){
            if (Keys.Left == direction && PosX > 0)
            {
               PosX -= 100;
            }
            else if(Keys.Right == direction && PosX < 700)
            {
                PosX += 100;
            }

        }
    }
}
