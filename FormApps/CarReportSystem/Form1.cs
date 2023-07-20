using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<CarReport> carReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = carReports;
            //dgvを書き換えるとcarReportsに反映される
        }

        //追加ボタンのイベントハンドラー
        private void btAdd_Click(object sender, EventArgs e) {

            statusLabelDisp();
            if (cbAuthor.Text == "") {
                statusLabelDisp("記録者を入力してください");
                return;
            }
            else if (cbCarName.Text == "") {
                statusLabelDisp("車名を入力してください");
                return;
            }
            else {
                carReports.Add(new CarReport {
                    date = dtpDate.Value,
                    Author = cbAuthor.Text,
                    Maker = getSelectedMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    CarImage = pbCarImage.Image,
                });

                btDeleteReport.Enabled = true;
                btModifyReport.Enabled = true;

                cbHisotryAdd();

                resetSelectedButton();
            }
        }

        private void cbHisotryAdd() {
            if (!cbAuthor.Items.Contains(cbAuthor.Text)) {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
            if (!cbCarName.Items.Contains(cbCarName.Text)) {
                cbCarName.Items.Add(cbCarName.Text);
            }
        }


        //編集ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {

            statusLabelDisp();
            if (cbAuthor.Text == "") {
                statusLabelDisp("記録者を入力してください"); return;
            }
            else if (cbCarName.Text.Equals("")) {
                //if (String.IsNullOrEmpty(cbCarName.Text))
                //if (cbAuthor.Text == "")

                statusLabelDisp("車名を入力してください");
                return;
            }
            else {
                carReports[dgvCarReports.CurrentRow.Index] = new CarReport {
                    date = dtpDate.Value,
                    Author = cbAuthor.Text,
                    Maker = getSelectedMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    CarImage = pbCarImage.Image,
                };
                cbAuthor.Items.Add(cbAuthor.Text);
                cbCarName.Items.Add(cbCarName.Text);
                deleteModifyInvalidCheck();
                resetSelectedButton();
            }

            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value;
            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value; こんな風に他の属性も変える方法もある
            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value;
            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value;
            //dgvCarReports.Refresh();

        }

        //削除ボタン
        private void btDeleteReport_Click(object sender, EventArgs e) {
            carReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            deleteModifyInvalidCheck();
            resetSelectedButton();

        }
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();

        }

        private void deleteModifyInvalidCheck() {
            if (carReports.Count < 1) {

                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
            }
        }

        //指定したメーカーのラジオボタンをセット
        private void changeMakerButton(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                case CarReport.MakerGroup.データなし:
                    break;
                default:
                    break;
            }

            //foreach (var item in gbMaker.Controls) {
            //    if (int.Parse(( (RadioButton)item ).Tag.ToString()) == ( (int)targetMaker)) {
            //        ( (RadioButton)item ).Checked = true;
            //    }
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }



        private CarReport.MakerGroup getSelectedMaker() {


            foreach (var item in gbMaker.Controls) {
                int num;
                //string str;
                if (( (RadioButton)item ).Checked) {

                    num = int.Parse(( (RadioButton)item ).Tag.ToString());

                    return (CarReport.MakerGroup)num;
                    //str = ( (RadioButton)item ).Tag.ToString();
                    //return (CarReport.MakerGroup)Enum.ToObject(typeof(CarReport.MakerGroup),num );

                }
            }



            return CarReport.MakerGroup.データなし;

        }

        private void btImageOpen_Click(object sender, EventArgs e) {

        }

        private void btImageOpen_Click_1(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() != DialogResult.Cancel) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            }
            
            
        }


        private void dgvCarReports_Click(object sender, EventArgs e) {

            CarReport targetData = carReports[dgvCarReports.CurrentRow.Index];

            dtpDate.Value = targetData.date;
            cbAuthor.Text = targetData.Author;
            changeMakerButton(targetData.Maker);
            cbCarName.Text = targetData.CarName;
            tbReport.Text = targetData.Report;
            pbCarImage.Image = targetData.CarImage;
        }

        private void resetSelectedButton() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = null;
            rbToyota.Checked = true;
            rbToyota.Checked = false;
            cbCarName.Text = null;
            tbReport.Text = null;
            pbCarImage.Image = null;
            tsInfoText.Text = null;
            //statusLabelDisp("");

            dgvCarReports.ClearSelection();
        }

        //オプション引数
        private void statusLabelDisp(string message = "") {
            tsInfoText.Text = message;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void 画面の色の変更ToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() != DialogResult.OK) {

                BackColor = cdColor.Color;
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
    }
}

