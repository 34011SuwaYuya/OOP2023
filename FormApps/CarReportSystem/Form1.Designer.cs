﻿
namespace CarReportSystem {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbDaihatsu = new System.Windows.Forms.RadioButton();
            this.rbImported = new System.Windows.Forms.RadioButton();
            this.rbSuzuki = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvCarReports = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.pbCarImage = new System.Windows.Forms.PictureBox();
            this.btAddReport = new System.Windows.Forms.Button();
            this.btModifyReport = new System.Windows.Forms.Button();
            this.btDeleteReport = new System.Windows.Forms.Button();
            this.menuItems = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImageFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.statusDisp = new System.Windows.Forms.StatusStrip();
            this.tsTimeDisp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.cdColor = new System.Windows.Forms.ColorDialog();
            this.btScaleChange = new System.Windows.Forms.Button();
            this.tmTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.ofdCarReportOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdCarReportSave = new System.Windows.Forms.SaveFileDialog();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.menuItems.SuspendLayout();
            this.statusDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(84, 25);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(84, 58);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(200, 20);
            this.cbAuthor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbOther);
            this.gbMaker.Controls.Add(this.rbDaihatsu);
            this.gbMaker.Controls.Add(this.rbImported);
            this.gbMaker.Controls.Add(this.rbSuzuki);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbSubaru);
            this.gbMaker.Controls.Add(this.rbNissan);
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Location = new System.Drawing.Point(84, 84);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(256, 74);
            this.gbMaker.TabIndex = 2;
            this.gbMaker.TabStop = false;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(189, 44);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 9;
            this.rbOther.TabStop = true;
            this.rbOther.Tag = "7";
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbDaihatsu
            // 
            this.rbDaihatsu.AutoSize = true;
            this.rbDaihatsu.Location = new System.Drawing.Point(123, 44);
            this.rbDaihatsu.Name = "rbDaihatsu";
            this.rbDaihatsu.Size = new System.Drawing.Size(60, 16);
            this.rbDaihatsu.TabIndex = 8;
            this.rbDaihatsu.TabStop = true;
            this.rbDaihatsu.Tag = "5";
            this.rbDaihatsu.Text = "ダイハツ";
            this.rbDaihatsu.UseVisualStyleBackColor = true;
            // 
            // rbImported
            // 
            this.rbImported.AutoSize = true;
            this.rbImported.Location = new System.Drawing.Point(189, 12);
            this.rbImported.Name = "rbImported";
            this.rbImported.Size = new System.Drawing.Size(59, 16);
            this.rbImported.TabIndex = 5;
            this.rbImported.TabStop = true;
            this.rbImported.Tag = "6";
            this.rbImported.Text = "輸入車";
            this.rbImported.UseVisualStyleBackColor = true;
            // 
            // rbSuzuki
            // 
            this.rbSuzuki.AutoSize = true;
            this.rbSuzuki.Location = new System.Drawing.Point(65, 44);
            this.rbSuzuki.Name = "rbSuzuki";
            this.rbSuzuki.Size = new System.Drawing.Size(52, 16);
            this.rbSuzuki.TabIndex = 7;
            this.rbSuzuki.TabStop = true;
            this.rbSuzuki.Tag = "4";
            this.rbSuzuki.Text = "スズキ";
            this.rbSuzuki.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(123, 12);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 4;
            this.rbHonda.TabStop = true;
            this.rbHonda.Tag = "2";
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(7, 44);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 6;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Tag = "3";
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(65, 12);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 3;
            this.rbNissan.TabStop = true;
            this.rbNissan.Tag = "1";
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(7, 12);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 2;
            this.rbToyota.TabStop = true;
            this.rbToyota.Tag = "0";
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(84, 170);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(200, 20);
            this.cbCarName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(85, 202);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(336, 83);
            this.tbReport.TabIndex = 9;
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.AllowUserToAddRows = false;
            this.dgvCarReports.AllowUserToDeleteRows = false;
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Location = new System.Drawing.Point(84, 315);
            this.dgvCarReports.MultiSelect = false;
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.ReadOnly = true;
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReports.Size = new System.Drawing.Size(610, 145);
            this.dgvCarReports.TabIndex = 10;
            this.dgvCarReports.Click += new System.EventHandler(this.dgvCarReports_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(465, 53);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 11;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click_1);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(546, 53);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 12;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCarImage.Location = new System.Drawing.Point(427, 84);
            this.pbCarImage.Name = "pbCarImage";
            this.pbCarImage.Size = new System.Drawing.Size(267, 146);
            this.pbCarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarImage.TabIndex = 8;
            this.pbCarImage.TabStop = false;
            // 
            // btAddReport
            // 
            this.btAddReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btAddReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddReport.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddReport.Location = new System.Drawing.Point(457, 236);
            this.btAddReport.Name = "btAddReport";
            this.btAddReport.Size = new System.Drawing.Size(75, 49);
            this.btAddReport.TabIndex = 14;
            this.btAddReport.Text = "追加";
            this.btAddReport.UseVisualStyleBackColor = false;
            this.btAddReport.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btModifyReport
            // 
            this.btModifyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btModifyReport.Enabled = false;
            this.btModifyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModifyReport.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btModifyReport.Location = new System.Drawing.Point(538, 236);
            this.btModifyReport.Name = "btModifyReport";
            this.btModifyReport.Size = new System.Drawing.Size(75, 49);
            this.btModifyReport.TabIndex = 15;
            this.btModifyReport.Text = "修正";
            this.btModifyReport.UseVisualStyleBackColor = false;
            this.btModifyReport.Click += new System.EventHandler(this.btModifyReport_Click);
            // 
            // btDeleteReport
            // 
            this.btDeleteReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDeleteReport.Enabled = false;
            this.btDeleteReport.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDeleteReport.Location = new System.Drawing.Point(619, 236);
            this.btDeleteReport.Name = "btDeleteReport";
            this.btDeleteReport.Size = new System.Drawing.Size(75, 49);
            this.btDeleteReport.TabIndex = 16;
            this.btDeleteReport.Text = "削除";
            this.btDeleteReport.UseVisualStyleBackColor = false;
            this.btDeleteReport.Click += new System.EventHandler(this.btDeleteReport_Click);
            // 
            // menuItems
            // 
            this.menuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuItems.Location = new System.Drawing.Point(0, 0);
            this.menuItems.Name = "menuItems";
            this.menuItems.Size = new System.Drawing.Size(786, 24);
            this.menuItems.TabIndex = 13;
            this.menuItems.Text = "menuStrip4";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くEToolStripMenuItem,
            this.保存SToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くEToolStripMenuItem
            // 
            this.開くEToolStripMenuItem.Name = "開くEToolStripMenuItem";
            this.開くEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くEToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.開くEToolStripMenuItem.Text = "開く(&O)...";
            this.開くEToolStripMenuItem.Click += new System.EventHandler(this.開くEToolStripMenuItem_Click);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.保存SToolStripMenuItem.Text = "保存(&S)...";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.色設定ToolStripMenuItem});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.設定ToolStripMenuItem.Text = "編集&(E)";
            // 
            // 色設定ToolStripMenuItem
            // 
            this.色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            this.色設定ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.色設定ToolStripMenuItem.Text = "色設定...";
            this.色設定ToolStripMenuItem.Click += new System.EventHandler(this.色設定ToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報ToolStripMenuItem_Click);
            // 
            // ofdImageFileOpen
            // 
            this.ofdImageFileOpen.FileName = "openFileDialog1";
            // 
            // statusDisp
            // 
            this.statusDisp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTimeDisp,
            this.tsInfo});
            this.statusDisp.Location = new System.Drawing.Point(0, 512);
            this.statusDisp.Name = "statusDisp";
            this.statusDisp.Size = new System.Drawing.Size(786, 22);
            this.statusDisp.TabIndex = 15;
            this.statusDisp.Text = "statusStrip1";
            // 
            // tsTimeDisp
            // 
            this.tsTimeDisp.Name = "tsTimeDisp";
            this.tsTimeDisp.Size = new System.Drawing.Size(55, 17);
            this.tsTimeDisp.Text = "時刻表示";
            // 
            // tsInfo
            // 
            this.tsInfo.Name = "tsInfo";
            this.tsInfo.Size = new System.Drawing.Size(82, 17);
            this.tsInfo.Text = "インフォメーション";
            // 
            // btScaleChange
            // 
            this.btScaleChange.Location = new System.Drawing.Point(627, 53);
            this.btScaleChange.Name = "btScaleChange";
            this.btScaleChange.Size = new System.Drawing.Size(67, 23);
            this.btScaleChange.TabIndex = 13;
            this.btScaleChange.Text = "サイズ変更";
            this.btScaleChange.UseVisualStyleBackColor = true;
            this.btScaleChange.Click += new System.EventHandler(this.btScaleChange_Click);
            // 
            // tmTimeUpdate
            // 
            this.tmTimeUpdate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 534);
            this.Controls.Add(this.btScaleChange);
            this.Controls.Add(this.statusDisp);
            this.Controls.Add(this.btDeleteReport);
            this.Controls.Add(this.btModifyReport);
            this.Controls.Add(this.btAddReport);
            this.Controls.Add(this.pbCarImage);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.dgvCarReports);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "カーレポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).EndInit();
            this.menuItems.ResumeLayout(false);
            this.menuItems.PerformLayout();
            this.statusDisp.ResumeLayout(false);
            this.statusDisp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbDaihatsu;
        private System.Windows.Forms.RadioButton rbImported;
        private System.Windows.Forms.RadioButton rbSuzuki;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.DataGridView dgvCarReports;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.PictureBox pbCarImage;
        private System.Windows.Forms.Button btAddReport;
        private System.Windows.Forms.Button btModifyReport;
        private System.Windows.Forms.Button btDeleteReport;
        private System.Windows.Forms.MenuStrip menuItems;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdImageFileOpen;
        private System.Windows.Forms.StatusStrip statusDisp;
        private System.Windows.Forms.ToolStripStatusLabel tsTimeDisp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColor;
        private System.Windows.Forms.Button btScaleChange;
        private System.Windows.Forms.ToolStripStatusLabel tsInfo;
        private System.Windows.Forms.Timer tmTimeUpdate;
        private System.Windows.Forms.OpenFileDialog ofdCarReportOpen;
        private System.Windows.Forms.SaveFileDialog sfdCarReportSave;
    }
}

