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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        //追加ボタンのイベントハンドラー
        private void btAdd_Click(object sender, EventArgs e) {

           

            

            carReports.Add(new CarReport{
               date = dtpDate.Value, Author = cbAuthor.Text, CarName = cbCarName.Text, Report = tbReport.Text
            }
            );
        }

        private void btModify_Click(object sender, EventArgs e) {

        }

        private void btDelete_Click(object sender, EventArgs e) {

        }

        private CarReport.MakerGroup getSelectedMaker() {

            return CarReport.MakerGroup.その他;

        }
    }
}
