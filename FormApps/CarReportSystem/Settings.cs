using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    //設定情報
    public class Settings {
        private static Settings instance;

        public int MainFormColor { get; set; }

        public static Settings getInstance() {
            if (instance == null) {
                instance = new Settings ();
            }

            return instance;
        }

        //コンストラクタ
        private Settings() {

        }
    }
}
