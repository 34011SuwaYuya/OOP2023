
using System;

namespace CalendarApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btDayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btBackYear = new System.Windows.Forms.Button();
            this.btForwardYear = new System.Windows.Forms.Button();
            this.btBackMonth = new System.Windows.Forms.Button();
            this.btForwardMonth = new System.Windows.Forms.Button();
            this.btBackDay = new System.Windows.Forms.Button();
            this.btForward = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeTEXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付";
            // 
            // dtp
            // 
            this.dtp.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtp.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtp.CalendarTrailingForeColor = System.Drawing.Color.DarkOrange;
            this.dtp.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dtp.Location = new System.Drawing.Point(120, 12);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 31);
            this.dtp.TabIndex = 1;
            this.dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btDayCalc
            // 
            this.btDayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btDayCalc.Location = new System.Drawing.Point(120, 49);
            this.btDayCalc.Name = "btDayCalc";
            this.btDayCalc.Size = new System.Drawing.Size(116, 47);
            this.btDayCalc.TabIndex = 2;
            this.btDayCalc.Text = "日数計算";
            this.btDayCalc.UseVisualStyleBackColor = true;
            this.btDayCalc.Click += new System.EventHandler(this.btDayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.tbMessage.Location = new System.Drawing.Point(288, 122);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(500, 34);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btBackYear
            // 
            this.btBackYear.Location = new System.Drawing.Point(53, 145);
            this.btBackYear.Name = "btBackYear";
            this.btBackYear.Size = new System.Drawing.Size(75, 23);
            this.btBackYear.TabIndex = 4;
            this.btBackYear.Text = "-年";
            this.btBackYear.UseVisualStyleBackColor = true;
            this.btBackYear.Click += new System.EventHandler(this.btBackYear_Click);
            // 
            // btForwardYear
            // 
            this.btForwardYear.Location = new System.Drawing.Point(171, 145);
            this.btForwardYear.Name = "btForwardYear";
            this.btForwardYear.Size = new System.Drawing.Size(75, 23);
            this.btForwardYear.TabIndex = 5;
            this.btForwardYear.Text = "+年";
            this.btForwardYear.UseVisualStyleBackColor = true;
            this.btForwardYear.Click += new System.EventHandler(this.btForwardYear_Click);
            // 
            // btBackMonth
            // 
            this.btBackMonth.Location = new System.Drawing.Point(53, 185);
            this.btBackMonth.Name = "btBackMonth";
            this.btBackMonth.Size = new System.Drawing.Size(75, 23);
            this.btBackMonth.TabIndex = 6;
            this.btBackMonth.Text = "-月";
            this.btBackMonth.UseVisualStyleBackColor = true;
            this.btBackMonth.Click += new System.EventHandler(this.btBackMonth_Click);
            // 
            // btForwardMonth
            // 
            this.btForwardMonth.Location = new System.Drawing.Point(171, 185);
            this.btForwardMonth.Name = "btForwardMonth";
            this.btForwardMonth.Size = new System.Drawing.Size(75, 23);
            this.btForwardMonth.TabIndex = 7;
            this.btForwardMonth.Text = "+月";
            this.btForwardMonth.UseVisualStyleBackColor = true;
            this.btForwardMonth.Click += new System.EventHandler(this.btForwardMonth_Click);
            // 
            // btBackDay
            // 
            this.btBackDay.Location = new System.Drawing.Point(53, 228);
            this.btBackDay.Name = "btBackDay";
            this.btBackDay.Size = new System.Drawing.Size(75, 23);
            this.btBackDay.TabIndex = 8;
            this.btBackDay.Text = "-日";
            this.btBackDay.UseVisualStyleBackColor = true;
            this.btBackDay.Click += new System.EventHandler(this.btBackDay_Click);
            // 
            // btForward
            // 
            this.btForward.Location = new System.Drawing.Point(171, 227);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(75, 23);
            this.btForward.TabIndex = 9;
            this.btForward.Text = "+日";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(55, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "現在時刻：";
            // 
            // timeTEXT
            // 
            this.timeTEXT.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.timeTEXT.Location = new System.Drawing.Point(195, 342);
            this.timeTEXT.Name = "timeTEXT";
            this.timeTEXT.Size = new System.Drawing.Size(300, 34);
            this.timeTEXT.TabIndex = 11;
            this.timeTEXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeTEXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btBackDay);
            this.Controls.Add(this.btForwardMonth);
            this.Controls.Add(this.btBackMonth);
            this.Controls.Add(this.btForwardYear);
            this.Controls.Add(this.btBackYear);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btDayCalc);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //最初に一度だけ呼ばれる
        private void Form1_Load(object sender, EventArgs e) {
            timeTEXT.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btDayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btBackYear;
        private System.Windows.Forms.Button btForwardYear;
        private System.Windows.Forms.Button btBackMonth;
        private System.Windows.Forms.Button btForwardMonth;
        private System.Windows.Forms.Button btBackDay;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeTEXT;
    }
}

