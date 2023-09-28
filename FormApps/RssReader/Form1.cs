using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        IEnumerable<ItemData> nodes ;

        public Form1() {
            InitializeComponent ();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead ( tbUrl.Text );

                XDocument xdoc = XDocument.Load ( url );


                nodes = xdoc.Root.Descendants ( "item" ).Select(x => new ItemData {
                    Title = x.Element("title").Value,
                    link =(string) x.Element ( "link" ),
                }
                );

                foreach (var item in nodes) {
                    lbRssTitle.Items.Add ( item.Title);
                    //lbRssTitle.Items.Add ( item.link );
                }

            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            //var targetUrl = lbRssTitle.SelectedItem.ToString();
            var targetUrl = nodes.First ( n => n.Title == lbRssTitle.SelectedItem.ToString()).link.ToString();
            wbBrowser.Navigate ( targetUrl);    //ここに対象のページのアドレスを入れる
        }

        private void lbRssTitle_MouseClick(object sender, MouseEventArgs e) {
        }
    }
}
