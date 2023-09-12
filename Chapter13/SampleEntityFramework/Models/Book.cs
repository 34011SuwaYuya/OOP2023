using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models {
    public class Book {

        public int Id{ get; set; }
        public string Title{ get; set; }
        public int PublishedYear{ get; set; }
            //dgvを書き換えるとcarReportsに反映される
        public virtual Author Author { get; set; }
    }
}
