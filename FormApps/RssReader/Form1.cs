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
        Dictionary<string, string> titleAndUrl = new Dictionary<string, string> ();
        public Form1() {
            InitializeComponent ();
            initilizeTitleUrl ();
            setCBGenre ();
        }

        private void initilizeTitleUrl() {
            titleAndUrl.Add ( "主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml" );
            titleAndUrl.Add ( "国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml" );
            titleAndUrl.Add ( "国際", "https://news.yahoo.co.jp/rss/topics/world.xml" );
            titleAndUrl.Add ( "経済", "https://news.yahoo.co.jp/rss/topics/business.xml" );
            titleAndUrl.Add ( "エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml" );
            titleAndUrl.Add ( "スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml" );
            titleAndUrl.Add ( "IT", "https://news.yahoo.co.jp/rss/topics/it.xml" );
            titleAndUrl.Add ( "科学", "https://news.yahoo.co.jp/rss/topics/science.xml" );
            titleAndUrl.Add ( "地域", "https://news.yahoo.co.jp/rss/topics/local.xml" );
        }

        //最初のテキストボックスを消した
        //private void btGet_Click(object sender, EventArgs e) {
        //    using (var wc = new WebClient()) {
        //        if (tbUrl.Text =="") {
        //            return;
        //        }

        //        var url = wc.OpenRead ( tbUrl.Text );
        //        XDocument xdoc = XDocument.Load ( url );


        //        nodes = xdoc.Root.Descendants ( "item" ).Select(x => new ItemData {
        //            Title = x.Element("title").Value,
        //            link =(string) x.Element ( "link" ),
        //        }
        //        ).ToList();

        //        lbRssTitle.Items.Clear ();
        //        foreach (var item in nodes) {
        //            lbRssTitle.Items.Add ( item.Title);
        //            //lbRssTitle.Items.Add ( item.link );
        //        }

        //    }
        //}

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

            foreach (var item in titleAndUrl) {
                cbGenre.Items.Add ( item.Key );
            }
        }

        private void btGenreGet_Click(object sender, EventArgs e) {
            string genrePage = "";
            bool comboboxAdd = false;

            if (cbGenre.Text == "") {
                return;
            }

            if (titleAndUrl.ContainsKey(cbGenre.Text)) {
                genrePage = titleAndUrl[cbGenre.Text];
            }
            else {
                genrePage = cbGenre.Text;
                comboboxAdd = true;
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
                if (comboboxAdd && !titleAndUrl.ContainsKey(cbGenre.Text)) {
                    cbGenre.Items.Add ( xdoc.Root.Element ( "channel" ).Element ( "title" ).Value );
                    titleAndUrl.Add ( xdoc.Root.Element ( "channel" ).Element ( "title" ).Value, cbGenre.Text );
                }

            }
        }
    }
}
