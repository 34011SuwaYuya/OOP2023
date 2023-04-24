﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {       //Formクラスを継承している

        private Timer moveTimer;        //タイマー用
        private SoccerBall soccerBall;
        private PictureBox pb;

        private List<Obj> balls = new List<Obj>();    //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();      //画像表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {      //ctorでtabキー コンストラクタの作成
            this.Size = new System.Drawing.Size(800, 600);
            this.BackColor = Color.Green;
            this.Text = "BallGame";

            this.MouseClick += Program_MouseClick;

            moveTimer = new Timer();
            moveTimer.Interval = 10;      //タイマーのインターバル（ｍｓ）
            moveTimer.Tick += MoveTimer_Tick;       //デリゲート登録

        }

        private void Program_MouseClick(object sender, MouseEventArgs e) {  //イベントハンドラー
            //左クリックでサッカーボール生成時用
            //ボールインスタンス生成

            soccerBall = new SoccerBall(e.X, e.Y);
            pb = new PictureBox();
            //画像を表示するコントロール
            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
            pb.Size = new Size(50, 50);     //画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            balls.Add(soccerBall);
            pbs.Add(pb);

            moveTimer.Start();
            this.Text = "BallGame 現在：" + balls.Count;
        }
        /*
        private void Program_MouseClick(object sender, MouseEventArgs e) {  //イベントハンドラー
            //右クリックでテニスボール作成時
            //ボールインスタンス生成

            soccerBall = new SoccerBall(e.X, e.Y);
            pb = new PictureBox();
            //画像を表示するコントロール
            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
            pb.Size = new Size(50, 50);     //画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pb.Parent = this;

            balls.Add(soccerBall);
            pbs.Add(pb);

            moveTimer.Start();
            this.Text = "BallGame 現在：" + balls.Count;
        }
        */
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
