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

        //追加ボタンのイベントハンドラー
        private void btAdd_Click(object sender, EventArgs e) {
            carReports.Add(new CarReport{
               date = dtpDate.Value, Author = cbAuthor.Text, Maker = getSelectedMaker() , CarName = cbCarName.Text, Report = tbReport.Text, CarImage = pbCarImage.Image, 
            }
            );
        }

        private CarReport.MakerGroup getSelectedMaker() {

            
            foreach (var item in gbMaker.Controls) {
                int num;
                //string str;
                if(((RadioButton)item ).Checked) {

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
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
        }

        //削除ボタン
        private void btDeleteReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.RowCount >= 1) {
                carReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            }
            
            
        }

        //編集ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (carReports.Count >= 1) {
                carReports[dgvCarReports.CurrentRow.Index] = new CarReport {
                    date = dtpDate.Value,
                    Author = cbAuthor.Text,
                    Maker = getSelectedMaker(),
                    CarName = cbCarName.Text,
                    Report = tbReport.Text,
                    CarImage = pbCarImage.Image,
                };
            }

            

            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value;
            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value; こんな風に他の属性も変える方法もある
            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value;
            //carReports[dgvCarReports.CurrentRow.Index].date = dtpDate.Value;
            //dgvCarReports.Refresh();

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

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}

