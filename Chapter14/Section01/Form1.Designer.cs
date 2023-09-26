
namespace Section01 {
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
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btRunNotepad = new System.Windows.Forms.Button();
            this.btRunAndWaitNoetpad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRunNotepad
            // 
            this.btRunNotepad.Location = new System.Drawing.Point(107, 31);
            this.btRunNotepad.Name = "btRunNotepad";
            this.btRunNotepad.Size = new System.Drawing.Size(163, 23);
            this.btRunNotepad.TabIndex = 0;
            this.btRunNotepad.Text = "RunNotepad";
            this.btRunNotepad.UseVisualStyleBackColor = true;
            this.btRunNotepad.Click += new System.EventHandler(this.btRunNotepad_Click);
            // 
            // btRunAndWaitNoetpad
            // 
            this.btRunAndWaitNoetpad.Location = new System.Drawing.Point(107, 86);
            this.btRunAndWaitNoetpad.Name = "btRunAndWaitNoetpad";
            this.btRunAndWaitNoetpad.Size = new System.Drawing.Size(163, 23);
            this.btRunAndWaitNoetpad.TabIndex = 1;
            this.btRunAndWaitNoetpad.Text = "RunAndWaitNotepad";
            this.btRunAndWaitNoetpad.UseVisualStyleBackColor = true;
            this.btRunAndWaitNoetpad.Click += new System.EventHandler(this.btRunAndWaitNoetpad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btRunAndWaitNoetpad);
            this.Controls.Add(this.btRunNotepad);
            this.Name = "Form1";
            this.Text = "14章1節";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRunNotepad;
        private System.Windows.Forms.Button btRunAndWaitNoetpad;
        private System.Windows.Forms.Button button1;
    }
}

