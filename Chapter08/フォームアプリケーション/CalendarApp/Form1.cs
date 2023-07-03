using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }
        

        private void btDayCalc_Click(object sender, EventArgs e) {
            tbMessage.Text = "入力して日付から" +(DateTime.Now - dtp.Value ) + "日が経過";
        }

        

        private void btBackDay_Click(object sender, EventArgs e) {
            dtp.Value = dtp.Value.AddDays(-1);
        }

        private void btForward_Click(object sender, EventArgs e) {
            dtp.Value = dtp.Value.AddDays(1);

        }

        private void btBackYear_Click(object sender, EventArgs e) {
            dtp.Value = dtp.Value.AddYears(-1);
        }

        private void btForwardYear_Click(object sender, EventArgs e) {
            dtp.Value = dtp.Value.AddYears(1);
        }

        private void btBackMonth_Click(object sender, EventArgs e) {
            dtp.Value = dtp.Value.AddMonths(-1);
        }

        private void btForwardMonth_Click(object sender, EventArgs e) {
            dtp.Value = dtp.Value.AddMonths(1);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }
    }
}
