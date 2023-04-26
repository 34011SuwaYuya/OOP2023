using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {       //Formクラスを継承している

        private Timer moveTimer;        //タイマー用

        private Ball ball;
        private PictureBox pb;

        Bar bar = new Bar(300);
        private PictureBox pbBar;

        private List<Ball> objects = new List<Ball>();    //ボールインスタンス格納用 Barインスタンスは格納しない
        private List<PictureBox> pbs = new List<PictureBox>();      //画像表示用 Barインスタンスは格納しない


        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {      //ctorでtabキー コンストラクタの作成
            this.Size = new System.Drawing.Size(800, 600);
            this.BackColor = Color.Green;
            this.Text = "BallGame ";


            //Barを表示する
            
            pbBar = new PictureBox();
            pbBar.Size = new Size(150, 10);
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pbBar.Parent = this;



            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            moveTimer = new Timer();
            moveTimer.Interval = 5;      //タイマーのインターバル（ｍｓ）
            moveTimer.Tick += MoveTimer_Tick;       //デリゲート登録
        }

        //キーが押されたときのイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        private void Program_MouseClick(object sender, MouseEventArgs e) {  //イベントハンドラー

            pb = new PictureBox();
            if (e.Button == MouseButtons.Left)
            {
                //左クリックでサッカーボール生成時用

                ball = new SoccerBall(e.X, e.Y);
                pb.Size = new Size(50, 50);     //画像の表示サイズ
            }
            else if(e.Button == MouseButtons.Right)
            {
                //右クリックでテニスボール作成時

                ball = new TennisBall(e.X, e.Y);
                pb.Size = new Size(25, 25);     //画像の表示サイズ
            }
            else
            {

            }

            //画像を表示するコントロール
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);

            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            objects.Add(ball);
            pbs.Add(pb);

            moveTimer.Start();
            this.Text = "BallGame テニス：" + TennisBall.Count + " サッカー：" + SoccerBall.Count;
        }
        
        private void MoveTimer_Tick(object sender, EventArgs e) {       //タイマータイムアウト時のイベントハンドラ

            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Move(pbBar,pbs[i]);  //移動のメッセージを送る
                pbs[i].Location = new Point((int)objects[i].PosX, (int)objects[i].PosY);
            }
            //foreach (var it in balls)
            //{
            //    it.move(); it は一つ一つのsoccerballインスタンス
            //}
        }
    }
}
