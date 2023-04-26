using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    abstract class Obj {
        //フィールド
  

        private Image image;
        private double posX;    //x座標
        private double posY;    //y座標



        public Obj(double PosX, double PosY, string Path) {
            this.posX = PosX;
            this.posY = PosY;
            Image = Image.FromFile(Path);
        }
        


        //プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        public abstract void Move(Keys direction);

    }
}
