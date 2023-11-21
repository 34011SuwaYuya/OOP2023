
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
            this.btGet = new System.Windows.Forms.Button();
            this.cbUrlOrGenre = new System.Windows.Forms.ComboBox();
            this.btFavorite = new System.Windows.Forms.Button();
            this.favoriteName = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.lbFavoriteName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(21, 107);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(920, 136);
            this.lbRssTitle.TabIndex = 2;
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
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(661, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 6;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // cbUrlOrGenre
            // 
            this.cbUrlOrGenre.FormattingEnabled = true;
            this.cbUrlOrGenre.Location = new System.Drawing.Point(157, 14);
            this.cbUrlOrGenre.Name = "cbUrlOrGenre";
            this.cbUrlOrGenre.Size = new System.Drawing.Size(498, 20);
            this.cbUrlOrGenre.TabIndex = 4;
            // 
            // btFavorite
            // 
            this.btFavorite.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFavorite.Location = new System.Drawing.Point(359, 50);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(75, 23);
            this.btFavorite.TabIndex = 8;
            this.btFavorite.Text = "登録";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // favoriteName
            // 
            this.favoriteName.Location = new System.Drawing.Point(157, 52);
            this.favoriteName.Name = "favoriteName";
            this.favoriteName.Size = new System.Drawing.Size(187, 19);
            this.favoriteName.TabIndex = 9;
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbUrl.Location = new System.Drawing.Point(21, 17);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(136, 12);
            this.lbUrl.TabIndex = 10;
            this.lbUrl.Text = "URL又はお気に入り名称：";
            // 
            // lbFavoriteName
            // 
            this.lbFavoriteName.AutoSize = true;
            this.lbFavoriteName.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFavoriteName.Location = new System.Drawing.Point(43, 55);
            this.lbFavoriteName.Name = "lbFavoriteName";
            this.lbFavoriteName.Size = new System.Drawing.Size(114, 12);
            this.lbFavoriteName.TabIndex = 11;
            this.lbFavoriteName.Text = "登録お気に入り名称：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 595);
            this.Controls.Add(this.lbFavoriteName);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.favoriteName);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.cbUrlOrGenre);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ComboBox cbUrlOrGenre;
        private System.Windows.Forms.Button btFavorite;
        private System.Windows.Forms.TextBox favoriteName;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Label lbFavoriteName;
    }
}

