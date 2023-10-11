
namespace RssReader {
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
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btUrlGet = new System.Windows.Forms.Button();
            this.cbUrlOrGenre = new System.Windows.Forms.ComboBox();
            this.btFavorite = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.lbFavoriteName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(21, 107);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(920, 136);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbRssTitle_MouseClick);
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(21, 261);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(920, 250);
            this.wbBrowser.TabIndex = 3;
            // 
            // btUrlGet
            // 
            this.btUrlGet.Location = new System.Drawing.Point(618, 12);
            this.btUrlGet.Name = "btUrlGet";
            this.btUrlGet.Size = new System.Drawing.Size(75, 23);
            this.btUrlGet.TabIndex = 6;
            this.btUrlGet.Text = "取得";
            this.btUrlGet.UseVisualStyleBackColor = true;
            this.btUrlGet.Click += new System.EventHandler(this.btUrlOrGenreGet_Click);
            // 
            // cbUrlOrGenre
            // 
            this.cbUrlOrGenre.FormattingEnabled = true;
            this.cbUrlOrGenre.Location = new System.Drawing.Point(114, 14);
            this.cbUrlOrGenre.Name = "cbUrlOrGenre";
            this.cbUrlOrGenre.Size = new System.Drawing.Size(498, 20);
            this.cbUrlOrGenre.TabIndex = 4;
            // 
            // btFavorite
            // 
            this.btFavorite.Location = new System.Drawing.Point(307, 50);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(106, 23);
            this.btFavorite.TabIndex = 8;
            this.btFavorite.Text = "お気に入り登録";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 19);
            this.textBox1.TabIndex = 9;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(21, 17);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(92, 12);
            this.lbUrl.TabIndex = 10;
            this.lbUrl.Text = "URL又はジャンル：";
            // 
            // lbFavoriteName
            // 
            this.lbFavoriteName.AutoSize = true;
            this.lbFavoriteName.Location = new System.Drawing.Point(21, 55);
            this.lbFavoriteName.Name = "lbFavoriteName";
            this.lbFavoriteName.Size = new System.Drawing.Size(86, 12);
            this.lbFavoriteName.TabIndex = 11;
            this.lbFavoriteName.Text = "お気に入り名称：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 595);
            this.Controls.Add(this.lbFavoriteName);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.btUrlGet);
            this.Controls.Add(this.cbUrlOrGenre);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btUrlGet;
        private System.Windows.Forms.ComboBox cbUrlOrGenre;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Label lbFavoriteName;
    }
}

