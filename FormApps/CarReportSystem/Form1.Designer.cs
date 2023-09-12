
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
            this.接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tbAuthorSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.dtpUntilSearch = new System.Windows.Forms.DateTimePicker();
            this.dtpFromSearch = new System.Windows.Forms.DateTimePicker();
            this.ResetSearchBT = new System.Windows.Forms.Button();
            this.MakerSearchBT = new System.Windows.Forms.Button();
            this.CarNameSearchBT = new System.Windows.Forms.Button();
            this.AuthorSearchBT = new System.Windows.Forms.Button();
            this.tbMakerSearch = new System.Windows.Forms.TextBox();
            this.tbCarNameSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.carReportTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202302DataSet = new CarReportSystem.infosys202302DataSet();
            this.carReportTableTableAdapter = new CarReportSystem.infosys202302DataSetTableAdapters.CarReportTableTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202302DataSetTableAdapters.TableAdapterManager();
            this.DateSearchBT = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarImage)).BeginInit();
            this.menuItems.SuspendLayout();
            this.statusDisp.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202302DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(73, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(73, 73);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(200, 20);
            this.cbAuthor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 111);
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
            this.gbMaker.Location = new System.Drawing.Point(73, 99);
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
            this.label4.Location = new System.Drawing.Point(32, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "車名：";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(73, 185);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(200, 20);
            this.cbCarName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "レポート：";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(74, 217);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(255, 280);
            this.tbReport.TabIndex = 9;
            // 
            // dgvCarReports
            // 
            this.dgvCarReports.AllowUserToAddRows = false;
            this.dgvCarReports.AllowUserToDeleteRows = false;
            this.dgvCarReports.AutoGenerateColumns = false;
            this.dgvCarReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvCarReports.DataSource = this.carReportTableBindingSource;
            this.dgvCarReports.Location = new System.Drawing.Point(741, 100);
            this.dgvCarReports.MultiSelect = false;
            this.dgvCarReports.Name = "dgvCarReports";
            this.dgvCarReports.RowHeadersVisible = false;
            this.dgvCarReports.RowTemplate.Height = 21;
            this.dgvCarReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReports.Size = new System.Drawing.Size(406, 372);
            this.dgvCarReports.TabIndex = 10;
            this.dgvCarReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarReports_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像：";
            // 
            // btImageOpen
            // 
            this.btImageOpen.Location = new System.Drawing.Point(454, 68);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(75, 23);
            this.btImageOpen.TabIndex = 11;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click_1);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Location = new System.Drawing.Point(535, 68);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(75, 23);
            this.btImageDelete.TabIndex = 12;
            this.btImageDelete.Text = "画像削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // pbCarImage
            // 
            this.pbCarImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbCarImage.Location = new System.Drawing.Point(416, 99);
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
            this.btAddReport.Location = new System.Drawing.Point(446, 251);
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
            this.btModifyReport.Location = new System.Drawing.Point(527, 251);
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
            this.btDeleteReport.Location = new System.Drawing.Point(608, 251);
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
            this.menuItems.Size = new System.Drawing.Size(1178, 24);
            this.menuItems.TabIndex = 13;
            this.menuItems.Text = "menuStrip4";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接続ToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了XToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 接続ToolStripMenuItem
            // 
            this.接続ToolStripMenuItem.Name = "接続ToolStripMenuItem";
            this.接続ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.接続ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.接続ToolStripMenuItem.Text = "接続(&N)...";
            this.接続ToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
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
            this.statusDisp.Size = new System.Drawing.Size(1178, 22);
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
            this.btScaleChange.Location = new System.Drawing.Point(616, 68);
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
            // tbAuthorSearch
            // 
            this.tbAuthorSearch.Location = new System.Drawing.Point(65, 18);
            this.tbAuthorSearch.Name = "tbAuthorSearch";
            this.tbAuthorSearch.Size = new System.Drawing.Size(151, 19);
            this.tbAuthorSearch.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "記録者";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.DateSearchBT);
            this.gbSearch.Controls.Add(this.dtpUntilSearch);
            this.gbSearch.Controls.Add(this.dtpFromSearch);
            this.gbSearch.Controls.Add(this.ResetSearchBT);
            this.gbSearch.Controls.Add(this.MakerSearchBT);
            this.gbSearch.Controls.Add(this.CarNameSearchBT);
            this.gbSearch.Controls.Add(this.AuthorSearchBT);
            this.gbSearch.Controls.Add(this.tbMakerSearch);
            this.gbSearch.Controls.Add(this.tbCarNameSearch);
            this.gbSearch.Controls.Add(this.label12);
            this.gbSearch.Controls.Add(this.label11);
            this.gbSearch.Controls.Add(this.label10);
            this.gbSearch.Controls.Add(this.label9);
            this.gbSearch.Controls.Add(this.tbAuthorSearch);
            this.gbSearch.Controls.Add(this.label8);
            this.gbSearch.Location = new System.Drawing.Point(374, 328);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(309, 172);
            this.gbSearch.TabIndex = 19;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "検索";
            this.gbSearch.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpUntilSearch
            // 
            this.dtpUntilSearch.Location = new System.Drawing.Point(65, 120);
            this.dtpUntilSearch.Name = "dtpUntilSearch";
            this.dtpUntilSearch.Size = new System.Drawing.Size(151, 19);
            this.dtpUntilSearch.TabIndex = 21;
            // 
            // dtpFromSearch
            // 
            this.dtpFromSearch.Location = new System.Drawing.Point(65, 97);
            this.dtpFromSearch.Name = "dtpFromSearch";
            this.dtpFromSearch.Size = new System.Drawing.Size(151, 19);
            this.dtpFromSearch.TabIndex = 21;
            // 
            // ResetSearchBT
            // 
            this.ResetSearchBT.Location = new System.Drawing.Point(222, 146);
            this.ResetSearchBT.Name = "ResetSearchBT";
            this.ResetSearchBT.Size = new System.Drawing.Size(75, 23);
            this.ResetSearchBT.TabIndex = 20;
            this.ResetSearchBT.Text = "リセット";
            this.ResetSearchBT.UseVisualStyleBackColor = true;
            this.ResetSearchBT.Click += new System.EventHandler(this.ResetSearchBT_Click);
            // 
            // MakerSearchBT
            // 
            this.MakerSearchBT.Location = new System.Drawing.Point(222, 68);
            this.MakerSearchBT.Name = "MakerSearchBT";
            this.MakerSearchBT.Size = new System.Drawing.Size(75, 23);
            this.MakerSearchBT.TabIndex = 19;
            this.MakerSearchBT.Text = "検索";
            this.MakerSearchBT.UseVisualStyleBackColor = true;
            this.MakerSearchBT.Click += new System.EventHandler(this.MakerSearchBT_Click);
            // 
            // CarNameSearchBT
            // 
            this.CarNameSearchBT.Location = new System.Drawing.Point(222, 41);
            this.CarNameSearchBT.Name = "CarNameSearchBT";
            this.CarNameSearchBT.Size = new System.Drawing.Size(75, 23);
            this.CarNameSearchBT.TabIndex = 19;
            this.CarNameSearchBT.Text = "検索";
            this.CarNameSearchBT.UseVisualStyleBackColor = true;
            this.CarNameSearchBT.Click += new System.EventHandler(this.CarNameSearchBT_Click);
            // 
            // AuthorSearchBT
            // 
            this.AuthorSearchBT.Location = new System.Drawing.Point(222, 16);
            this.AuthorSearchBT.Name = "AuthorSearchBT";
            this.AuthorSearchBT.Size = new System.Drawing.Size(75, 23);
            this.AuthorSearchBT.TabIndex = 19;
            this.AuthorSearchBT.Text = "検索";
            this.AuthorSearchBT.UseVisualStyleBackColor = true;
            this.AuthorSearchBT.Click += new System.EventHandler(this.AuthorSearchBT_Click);
            // 
            // tbMakerSearch
            // 
            this.tbMakerSearch.Location = new System.Drawing.Point(65, 70);
            this.tbMakerSearch.Name = "tbMakerSearch";
            this.tbMakerSearch.Size = new System.Drawing.Size(151, 19);
            this.tbMakerSearch.TabIndex = 17;
            // 
            // tbCarNameSearch
            // 
            this.tbCarNameSearch.Location = new System.Drawing.Point(65, 43);
            this.tbCarNameSearch.Name = "tbCarNameSearch";
            this.tbCarNameSearch.Size = new System.Drawing.Size(151, 19);
            this.tbCarNameSearch.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "Until";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "From";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "メーカー";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "車の名前";
            // 
            // carReportTableBindingSource
            // 
            this.carReportTableBindingSource.DataMember = "CarReportTable";
            this.carReportTableBindingSource.DataSource = this.infosys202302DataSet;
            // 
            // infosys202302DataSet
            // 
            this.infosys202302DataSet.DataSetName = "infosys202302DataSet";
            this.infosys202302DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportTableTableAdapter
            // 
            this.carReportTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableTableAdapter = this.carReportTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202302DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DateSearchBT
            // 
            this.DateSearchBT.Location = new System.Drawing.Point(222, 117);
            this.DateSearchBT.Name = "DateSearchBT";
            this.DateSearchBT.Size = new System.Drawing.Size(75, 23);
            this.DateSearchBT.TabIndex = 22;
            this.DateSearchBT.Text = "検索";
            this.DateSearchBT.UseVisualStyleBackColor = true;
            this.DateSearchBT.Click += new System.EventHandler(this.DateSearchBT_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 534);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.menuItems);
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
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReportTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202302DataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem 接続ToolStripMenuItem;
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
        private infosys202302DataSet infosys202302DataSet;
        private System.Windows.Forms.BindingSource carReportTableBindingSource;
        private infosys202302DataSetTableAdapters.CarReportTableTableAdapter carReportTableTableAdapter;
        private infosys202302DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbAuthorSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button CarNameSearchBT;
        private System.Windows.Forms.Button AuthorSearchBT;
        private System.Windows.Forms.TextBox tbCarNameSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button MakerSearchBT;
        private System.Windows.Forms.TextBox tbMakerSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ResetSearchBT;
        private System.Windows.Forms.DateTimePicker dtpFromSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpUntilSearch;
        private System.Windows.Forms.Button DateSearchBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}

