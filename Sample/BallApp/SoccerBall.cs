using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        //フィールド

        
        private Image image;    
        private double posX;    //x座標
        private double posY;    //y座標


        private double moveX ; //移動量(x方向)
        private double moveY ;
        Random rdm = new Random();


        //コンストラクタ
        public SoccerBall(double pointX, double pointY) {
            while (moveX == 0)
            {
                moveX = rdm.Next(-50, 50);
            }

            while (moveY == 0)
            {
                moveY = rdm.Next(-50, 50);
            }


            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = pointX;
            PosY = pointY;
        }

        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        //method
        public void Move() {    //外部からアクセスするものは大文字にすることが多い
           
            if (posX > 730 || posX < 0)        
            {
                moveX = -moveX;
            }

            if (posY > 520 || posY < 0)
            {
                moveY = -moveY;
            }
            posX += moveX;
            posY += moveY;
        }


    }
}
