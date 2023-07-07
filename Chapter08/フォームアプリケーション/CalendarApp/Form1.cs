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
            var dtp1 = dtp.Value;
            var now = DateTime.Now;
            tbMessage.Text = "入力して日付から" + (now - dtp1 ).Days + "日が経過";
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


        private void btAge_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            var years = GetAge(dtp.Value, now);

            textBox2.Text = "入力して日付生まれの人は現在" + years + "歳";
        }

        public int GetAge(DateTime birthDay, DateTime targetDay) {
            
            int age = targetDay.Year - birthDay.Year;
            if (targetDay < birthDay.AddYears(age)) {
                age--;
            }
            return age;
        }

        //タイマーイベントハンドラー
        private void tmTimeDisplay_Tick(object sender, EventArgs e) {
            DateTime now = DateTime.Now;
            timeTEXT.Text = now.ToString("yyyy年MM月dd日(ddd)HH時mm分ss秒");
            //timeTEXT.Text = now.ToShortDateString();
        }
    }
}
