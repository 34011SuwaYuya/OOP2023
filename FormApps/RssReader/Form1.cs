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
        List<ItemData> nodes ;

        public Form1() {
            InitializeComponent ();
            setCBGenre ();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead ( tbUrl.Text );

                XDocument xdoc = XDocument.Load ( url );


                nodes = xdoc.Root.Descendants ( "item" ).Select(x => new ItemData {
                    Title = x.Element("title").Value,
                    link =(string) x.Element ( "link" ),
                }
                ).ToList();

                foreach (var item in nodes) {
                    lbRssTitle.Items.Add ( item.Title);
                    //lbRssTitle.Items.Add ( item.link );
                }

            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            //var targetUrl = lbRssTitle.SelectedItem.ToString();
            //var targetUrl = nodes.First ( n => n.Title == lbRssTitle.SelectedItem.ToString()).link.ToString();
            string targetUrl;
            if (lbRssTitle.SelectedIndex < 0) {
                targetUrl = nodes[0].link.ToString ();
            }
            else {
                targetUrl = nodes[lbRssTitle.SelectedIndex].link.ToString ();
            }

            wbBrowser.Navigate ( targetUrl);    //ここに対象のページのアドレスを入れる
        }

        private void lbRssTitle_MouseClick(object sender, MouseEventArgs e) {
        }

        private void setCBGenre() {
            cbGenre.Items.Add ( "主要" );
            cbGenre.Items.Add ( "国内" );
            cbGenre.Items.Add ( "国際" );
            cbGenre.Items.Add ( "経済" );
            cbGenre.Items.Add ( "エンタメ" );
            cbGenre.Items.Add ( "スポーツ" );
            cbGenre.Items.Add ( "IT" );
            cbGenre.Items.Add ( "科学" );
            cbGenre.Items.Add ( "地域" );
        }

        private void btGenreGet_Click(object sender, EventArgs e) {
            string genre = cbGenre.Text ;
            string genrePage = "";

            switch (genre) {
                case "主要":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/top-picks.xml";
                    break;
                case "国内":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/domestic.xml";
                    break;

                case "国際":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/world.xml";
                    break;

                case "経済":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/business.xml";
                    break;

                case "エンタメ":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
                    break;

                case "スポーツ":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/sports.xml";
                    break;

                case "IT":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/it.xml";
                    break;

                case "科学":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/science.xml";
                    break;

                case "地域":
                    genrePage = "https://news.yahoo.co.jp/rss/topics/local.xml";
                    break;

                default:
                    newPage ();
                    break;
            }
            using (var wc = new WebClient ()) {

                
                var url = wc.OpenRead ( genrePage );

                XDocument xdoc = XDocument.Load ( url );

                nodes = xdoc.Root.Descendants ( "item" ).Select ( x => new ItemData {
                    Title = x.Element ( "title" ).Value,
                    link = (string)x.Element ( "link" ),
                }
                ).ToList();

                lbRssTitle.Items.Clear ();
                foreach (var item in nodes) {
                    lbRssTitle.Items.Add ( item.Title );
                }

            }
        }

        private void newPage() {
            
        }

    }
}
