using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {

    //商品クラス
    class Product {

        //商品コード
        public int Code { get; set; }   //自動実装プロパティ
        //商品名
        public string Name { get; set; }
        //商品価格（税抜き）
        public int Price { get; set; }

        //コンストラクタ
        public Product(int code, string name, int price) {
            this.Code = code;
            this.Name = name;
            this.Price = price;

        }
        
        //消費税額を求める（消費税率は10%）
        public int getTax() {
            return (int) (Price * 0.1) ;
        }

        //税込価格を求める
        public int GetPriceIncludingTax() {
            return Price + getTax();
        }

        public override string ToString() {
            //return base.ToString();
            return "商品コード:" + this.Code + " 商品名:" + this.Name + " 商品価格（税込)" + this.GetPriceIncludingTax();
        }


    }
}
