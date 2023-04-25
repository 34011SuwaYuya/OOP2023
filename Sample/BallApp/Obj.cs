using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    abstract class Obj {
        //フィールド
        Random rdm = new Random();

        private Image image;
        private double posX;    //x座標
        private double posY;    //y座標
        private double moveX; //移動量(x方向)
        private double moveY;
        private static int count;



        public Obj(double PosX, double PosY, string Path) {
            this.posX = PosX;
            this.posY = PosY;
            Image = Image.FromFile(Path);
            count++;
        }
        


        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }
        public static int Count { get => count; set => count = value; }
        public double MoveY { get => moveY; set => moveY = value; }
        public double MoveX { get => moveX; set => moveX = value; }

        //メソッド
        public abstract void Move();

        public void defaultMoveConfig() {
            while (MoveX == 0)
            {
                MoveX = rdm.Next(-50, 50);
            }

            while (MoveY == 0)
            {
                MoveY = rdm.Next(-50, 50);
            }
        }


    }
}
