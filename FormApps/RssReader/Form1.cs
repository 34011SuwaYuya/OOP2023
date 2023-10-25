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

/*
 * 取得ボタンを押すと[URL又はジャンル]のテキストのジャンルかurlの記事を取得する
 * お気に入り登録ボタンは[URL又はジャンル]と[お気に入り名称]の両方にテキストが入っている場合、登録作業と記事の取得を行う
 * お気に入りの名称が既存のものと被った場合は登録しない
 */



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


        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

            string targetUrl;
            if (lbRssTitle.SelectedIndex < 0) {
                targetUrl = nodes[0].link.ToString ();
            }
            else {
                targetUrl = nodes[lbRssTitle.SelectedIndex].link.ToString ();
            }

            wbBrowser.Navigate ( targetUrl);
        }


        private void setCBGenre() {
            foreach (var item in titleAndUrl) {
                cbUrlOrGenre.Items.Add ( item.Key );
            }
        }

        private void btGet_Click(object sender, EventArgs e) {
            string pageUrl = "";

            if (titleAndUrl.ContainsKey ( cbUrlOrGenre.Text )) {//有効なジャンル名が入っている場合
                pageUrl = titleAndUrl[cbUrlOrGenre.Text];
            }
            else if (ValidHttpURL ( cbUrlOrGenre.Text, out Uri resultURI )) {  //有効なurlが入っている
                pageUrl = cbUrlOrGenre.Text;
            }
            else {
                return;
            }

            openUrl ( pageUrl );
        }

        private void openUrl(string pageUrl) {
            using (var wc = new WebClient ()) {

                var url = wc.OpenRead ( pageUrl );

                XDocument xdoc = XDocument.Load ( url );

                nodes = xdoc.Root.Descendants ( "item" ).Select ( x => new ItemData {
                    Title = x.Element ( "title" ).Value,
                    link = (string)x.Element ( "link" ),
                }
                ).ToList ();

                lbRssTitle.Items.Clear ();
                foreach (var item in nodes) {
                    lbRssTitle.Items.Add ( item.Title );
                }
            }
        }


        //お気に入り登録
        private void btFavorite_Click(object sender, EventArgs e) {

            if (cbUrlOrGenre.Text == "" || favoriteName.Text == "") {
                return;
            }

            if (!ValidHttpURL(cbUrlOrGenre.Text, out Uri resultURI )) {
                return;
            }

            openUrl ( cbUrlOrGenre.Text );

            if (!titleAndUrl.ContainsKey ( favoriteName.Text )) {
                cbUrlOrGenre.Items.Add ( favoriteName.Text );
                titleAndUrl.Add ( favoriteName.Text, cbUrlOrGenre.Text );
            }
        }
      

        public static bool ValidHttpURL(string s, out Uri resultURI) {

            if (Uri.TryCreate ( s, UriKind.Absolute, out resultURI )) {
                return ( resultURI.Scheme == Uri.UriSchemeHttp || resultURI.Scheme == Uri.UriSchemeHttps );
            }
                
            return false;
        }

    }
}
