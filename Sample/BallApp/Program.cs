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
        private Obj ball;
        private PictureBox pb;

        private List<Obj> balls = new List<Obj>();    //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();      //画像表示用

        private int tennisNum;
        private int soccerNum;

        public int TennisNum { get => tennisNum; set => tennisNum = value; }
        public int SoccerNum { get => soccerNum; set => soccerNum = value; }

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {      //ctorでtabキー コンストラクタの作成
            this.Size = new System.Drawing.Size(800, 600);
            this.BackColor = Color.Green;
            this.Text = "BallGame ";

            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            moveTimer = new Timer();
            moveTimer.Interval = 10;      //タイマーのインターバル（ｍｓ）
            moveTimer.Tick += MoveTimer_Tick;       //デリゲート登録
        }

        private void Program_KeyDown(object sender, KeyEventArgs e) {


        }

        private void Program_MouseClick(object sender, MouseEventArgs e) {  //イベントハンドラー
            pb = new PictureBox();
            if (e.Button == MouseButtons.Left)
            {
                //左クリックでサッカーボール生成時用
                //ボールインスタンス生成

                ball = new SoccerBall(e.X, e.Y);
                soccerNum++;
                pb.Size = new Size(50, 50);     //画像の表示サイズ
            }
            else if(e.Button == MouseButtons.Right)
            {
                //右クリックでテニスボール作成時
                //ボールインスタンス生成

                ball = new TennisBall(e.X, e.Y);
                tennisNum++;
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

            balls.Add(ball);
            pbs.Add(pb);

            moveTimer.Start();
            this.Text = "BallGame テニス：" + TennisNum + " サッカー："+ soccerNum;
        }
        
        private void MoveTimer_Tick(object sender, EventArgs e) {       //タイマータイムアウト時のイベントハンドラ
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();  //移動のメッセージを送る
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }

            //foreach (var it in balls)
            //{
            //    it.Move(); it は一つ一つのsoccerballインスタンス
            //}
        }
    }
}
