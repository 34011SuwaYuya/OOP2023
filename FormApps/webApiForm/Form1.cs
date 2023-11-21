using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace webApiForm {
    public partial class Form1 : Form {
        List<ItemData> nodes;
        public Form1() {
            InitializeComponent ();
        }


        private void openURL() {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead ( "https://app.rakuten.co.jp/services/api/IchibaItem/Search/20220601?format=xml&keyword=%E6%A5%BD%E5%A4%A9&genreId=555086&applicationId=e06e2a5afcf14b52139c1fb6c58e9dbc" );
                XDocument xdoc = XDocument.Load ( url );
                nodes = xdoc.Root.Descendants ( "item" ).Select ( x => new ItemData {
                    itemName = x.Element ( "itemName" ).Value,
                    link = (string)x.Element ( "itemUrl" ),
                }
                ).ToList ();

                listBox1.Items.Clear ();
                foreach (var item in nodes) {
                    listBox1.Items.Add ( item.itemName );
                }

                webBrowser1.Navigate ( "about:blank" );
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            openURL ();
        }
    }
}
