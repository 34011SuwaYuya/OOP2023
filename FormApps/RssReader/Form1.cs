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
        public Form1() {
            InitializeComponent ();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead ( tbUrl.Text );

                XDocument xdoc = XDocument.Load ( url );
                var nodes = xdoc.Root.Descendants ( "item" ).Select(x => new ItemData {
                    Title = x.Element("title").Value,
                    //link = x.Element("link").Value,
                }
                );

                foreach (var item in nodes) {
                    lbRssTitle.Items.Add ( item.Title);
                    //lbRssTitle.Items.Add ( item.link);
                }

            }
        }
    }
}
