using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> carReports = new BindingList<CarReport>();

        //設定情報
        Settings settings = Settings.getInstance ();
       
        public Form1() {
            InitializeComponent();
            settings.MainFormColor = BackColor.ToArgb ();
        }

        private void Form1_Load(object sender, EventArgs e) {

            connectToDataBase ();

            //情報表示領域のテキストを初期化
            tsInfo.Text = "";
            tmTimeUpdate.Start ();
            tsTimeDisp.BackColor = Color.Black;
            tsTimeDisp.ForeColor = Color.White;

            dgvCarReports.RowHeadersVisible = false;
            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.AliceBlue; //全体に色を設定
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;//奇数行の色を上書き設定

            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;

            //設定ファイルを逆シリアル化して背景を設定
            //色の読み込み
            using (var reader = XmlReader.Create ( "settings.xml" )) {
                var serializer = new XmlSerializer ( typeof ( Settings ) );
                var settingFirst = serializer.Deserialize ( reader ) as Settings;

                BackColor = Color.FromArgb ( settingFirst.MainFormColor );
                settings.MainFormColor = BackColor.ToArgb ();
            }
        }


        //追加ボタンのイベントハンドラー
        private void btAdd_Click(object sender, EventArgs e) {
            statusLabelDisp ();
            if (cbAuthor.Text == "") {
                statusLabelDisp ( "記録者を入力してください" );
                return;
            }
            else if (cbCarName.Text == "") {
                statusLabelDisp ( "車名を入力してください" );
                return;
            }
            else {

                DataRow newRow = infosys202302DataSet.CarReportTable.NewRow();
                newRow[1] = dtpDate.Value;
                newRow[2] = cbAuthor.Text;
                newRow[3] = getSelectedMaker ().ToString ();
                newRow[4] = cbCarName.Text;
                newRow[5] = tbReport.Text;
                if (pbCarImage.Image != null) {
                    dgvCarReports.CurrentRow.Cells[6].Value = ImageToByteArray ( pbCarImage.Image );
                    newRow[6] = ImageToByteArray ( pbCarImage.Image );
                }
                
                infosys202302DataSet.CarReportTable.Rows.Add ( newRow );
                this.carReportTableTableAdapter.Update ( infosys202302DataSet.CarReportTable );

                btDeleteReport.Enabled = true;
                btModifyReport.Enabled = true;

                setCBAuthor ( cbAuthor.Text );
                setCBCarName ( cbCarName .Text);
                editItemClear ();
            }
        }

        //修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            
            statusLabelDisp();
            if (cbAuthor.Text == "") {
                statusLabelDisp("記録者を入力してください"); return;
            }
            else if (cbCarName.Text.Equals("")) {
                statusLabelDisp("車名を入力してください");
                return;
            }
            else {

                dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value ;
                dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
                dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker ();
                dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
                dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
                if (!pbCarImage.Image.Equals(DBNull.Value)) {
                    dgvCarReports.CurrentRow.Cells[6].Value = ImageToByteArray ( pbCarImage.Image );
                }
                

                cbAuthor.Items.Add(cbAuthor.Text);
                cbCarName.Items.Add(cbCarName.Text);
                deleteModifyButtonValidCheck();
                editItemClear();
            }


            this.Validate ();
            carReportTableBindingSource.EndEdit ();
            tableAdapterManager.UpdateAll ( infosys202302DataSet );
        }

        //削除ボタン
        private void btDeleteReport_Click(object sender, EventArgs e) {
            dgvCarReports.Rows.RemoveAt (dgvCarReports.CurrentRow.Index);
            carReportTableTableAdapter.Update ( infosys202302DataSet.CarReportTable );

            deleteModifyButtonValidCheck();
            editItemClear();

        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();

        }

        private void deleteModifyButtonValidCheck() {
            if (carReports.Count < 1) {

                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
            }
            else {

                btDeleteReport.Enabled = true;
                btModifyReport.Enabled = true;
            }
        }

        private void setCBAuthor(string author) {
            if (!cbAuthor.Items.Contains ( author )) {
                cbAuthor.Items.Add ( author );
            }
        }

        private void setCBCarName(string carName) {
            if (!cbCarName.Items.Contains ( carName )) {
                cbCarName.Items.Add ( carName );
            }
        }


        private void btImageOpen_Click_1(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() != DialogResult.Cancel) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
        }


        private void editItemClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = null;
            rbToyota.Checked = true;
            rbToyota.Checked = false;
            cbCarName.Text = null;
            tbReport.Text = null;
            pbCarImage.Image = null;
            tsTimeDisp.Text = null;

            dgvCarReports.ClearSelection();
        }

        //オプション引数
        private void statusLabelDisp(string message = "") {
            tsTimeDisp.Text = message;
        }


        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {

            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            if ((int)pbCarImage.SizeMode == 4) {
                pbCarImage.SizeMode = 0;
            }
            else {
                pbCarImage.SizeMode++ ;
            }
            
            /*
            private int mode;
            mode = mode < 4 ? ++mode : 0;
            mode = mode < 4 ? ((mode ==1) ? 3 : ++mode) : 0;
            2重のif文の構文
            private PictureBoxSizaMode mode;
            mode = mode < PictureBoxSizeMode.CeterImage
            pbCarImage.SizeMode = (PictureBoxSizeMode)mode;
            */
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {

            //設定ファイルのシリアル化
            try {
                using (var writer = XmlWriter.Create ( "settings.xml" )) {
                    var serializer = new XmlSerializer ( settings.GetType () );
                    serializer.Serialize ( writer, settings );
                }
            }
            catch (Exception) {
                MessageBox.Show ( "設定ファイル読み込みエラー" );
            }
        }
        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter ();
            Image img = (Image)imgconv.ConvertFrom ( b );
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter ();
            byte[] b = (byte[])imgconv.ConvertTo ( img, typeof ( byte[] ) );
            return b;
        }


        private void timer1_Tick(object sender, EventArgs e) {
            tsTimeDisp.Text = DateTime.Now.ToString("HH時mm分ss秒");
        }

        //保存ボタンを押したときに呼び出される
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            connectToDataBase ();
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }
        private void 開くEToolStripMenuItem_Click(object sender, EventArgs e) {
            connectToDataBase ();
        }

        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            
            if (dgvCarReports.Rows.Count != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString ();
                setSelectedMaker ( dgvCarReports.CurrentRow.Cells[3].Value.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString ();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString ();

                if (!dgvCarReports.CurrentRow.Cells[6].Value.Equals ( DBNull.Value ) && ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0) {
                    pbCarImage.Image = ByteArrayToImage ( (Byte[])dgvCarReports.CurrentRow.Cells[6].Value );
                }
                else {
                    pbCarImage.Image = null;
                }

                //pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value) ?
                //    ByteArrayToImage((Byte[]) dgvCarReports.CurrentRow.Cells[6].Value) : null;


                deleteModifyButtonValidCheck ();

                btModifyReport.Enabled = true;     //修正ボタン有効
                btDeleteReport.Enabled = true;     //削除ボタン有効
            }
        }

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate ();
            this.carReportTableBindingSource.EndEdit ();
            this.tableAdapterManager.UpdateAll ( this.infosys202302DataSet );

        }

        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in gbMaker.Controls) {
                int num;
                if (( (RadioButton)item ).Checked) {
                    num = int.Parse ( ( (RadioButton)item ).Tag.ToString () );
                    return (CarReport.MakerGroup)num;
                }
            }
            return CarReport.MakerGroup.データなし;
        }

        private void setSelectedMaker(string targetMaker) {
            switch (targetMaker) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        private void connectToDataBase() {
            // TODO: このコード行はデータを 'infosys202302DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill ( this.infosys202302DataSet.CarReportTable );
            foreach (var carReport in infosys202302DataSet.CarReportTable) {
                setCBAuthor ( carReport.Author );
                setCBCarName ( carReport.CarName );
            }
            dgvCarReports.ClearSelection ();
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void AuthorSearchBT_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByAuthor (infosys202302DataSet.CarReportTable,tbAuthorSearch.Text);
        }

        private void CarNameSearchBT_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByCarName ( infosys202302DataSet.CarReportTable, tbCarNameSearch.Text );
        }

        private void MakerSearchBT_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByMaker (infosys202302DataSet.CarReportTable, dtpFromSearch.Text);
        }

        private void ResetSearchBT_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.Fill (infosys202302DataSet.CarReportTable);
            SearchGB_Clear ();
        }

        private void DateSearchBT_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByDateBetween ( infosys202302DataSet.CarReportTable, dtpFromSearch.Text, dtpUntilSearch.Text );
        }


        private void orSearchBT_Click(object sender, EventArgs e) {
            carReportTableTableAdapter.FillByOrCondition ( infosys202302DataSet.CarReportTable, dtpFromSearch.Text, dtpUntilSearch.Text, tbAuthorSearch.Text, tbMakerSearch.Text );
        }

        private void SearchGB_Clear() {
            tbAuthorSearch.Text = null;
            tbCarNameSearch.Text = null;
            tbMakerSearch.Text = null;
            dtpFromSearch.Value = DateTime.Now;
        }

    }
}

