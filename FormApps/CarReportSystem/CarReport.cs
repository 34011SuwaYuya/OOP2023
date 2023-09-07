using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    [Serializable]

    public class CarReport {
        [System.ComponentModel.DisplayName("日付")]
        public DateTime date { get; set; }

        [System.ComponentModel.DisplayName("記録者")]
        public string Author { get; set; }

        [System.ComponentModel.DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }

        [System.ComponentModel.DisplayName("車名")]
        public string CarName { get; set; }

        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; }

        [System.ComponentModel.DisplayName("画像")]
        public Image CarImage { get; set; }


        //コンストラクタは本当は不要



        public enum MakerGroup {

            トヨタ,
            日産,
            ホンダ,
            スバル,
            スズキ,
            ダイハツ,
            輸入車,
            その他,
            データなし,
        }

        public static List<MakerGroup> makerGroups() {
            var arrayMaker = Enum.GetValues ( typeof ( MakerGroup ) );
            List<MakerGroup> makers = new List<MakerGroup>();
            foreach (var item in arrayMaker) {
                makers.Add ( (MakerGroup)item );
            }

            return makers;
        }
    }   

}
