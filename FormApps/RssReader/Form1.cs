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
                cbUrlOrGenre.Items.Add ( item.Key );
            }
        }

        private void btUrlOrGenreGet_Click(object sender, EventArgs e) {
            string pageUrl = "";



            if (titleAndUrl.ContainsKey ( cbUrlOrGenre.Text )) {//有効なジャンル名が入っている場合
                pageUrl = titleAndUrl[cbUrlOrGenre.Text];
            }
            else if (ValidHttpURL( cbUrlOrGenre.Text, out Uri resultURI )) {  //有効なurlが入っている
                pageUrl = cbUrlOrGenre.Text;
            }
            else {
                return;
            }

            using (var wc = new WebClient ()) {

                var url = wc.OpenRead ( pageUrl );

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

        
        //お気に入り登録
        private void btFavorite_Click(object sender, EventArgs e) {

            if (cbUrlOrGenre.Text == "" || textBox1.Text == "") {
                return;
            }

            if (!ValidHttpURL(cbUrlOrGenre.Text, out Uri resultURI )) {
                return;
            }


            using (var wc = new WebClient ()) {
                var url = wc.OpenRead ( cbUrlOrGenre.Text );
                XDocument xdoc = XDocument.Load ( url );
                nodes = xdoc.Root.Descendants ( "item" ).Select ( x => new ItemData {
                    Title = x.Element ( "title" ).Value,
                    link = (string)x.Element ( "link" ),
                }
                ).ToList ();

                //ListBox更新
                lbRssTitle.Items.Clear ();
                foreach (var item in nodes) {
                    lbRssTitle.Items.Add ( item.Title );
                }

                if (titleAndUrl.ContainsKey ( cbUrlOrGenre.Text )) {
                    cbUrlOrGenre.Items.Add ( textBox1.Text );
                    titleAndUrl.Add ( textBox1.Text, cbUrlOrGenre.Text );
                }
            }
        }
      

        public static bool ValidHttpURL(string s, out Uri resultURI) {
            //if (!Regex.IsMatch ( s, @"^https?:\/\/", RegexOptions.IgnoreCase ))
            //    s = "http://" + s;

            if (Uri.TryCreate ( s, UriKind.Absolute, out resultURI )) {
                return ( resultURI.Scheme == Uri.UriSchemeHttp || resultURI.Scheme == Uri.UriSchemeHttps );
            }
                
            return false;
        }
    }
}
