using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class YearMonth {
        public int Year {get; private set; }
        public int Month { get;private set; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        //4.1.2
        /*
        public bool Is21Century() {
            return 2001 <= Year && Year <= 2000; 
        }
        */

        public bool  Is21Century{
            get {
                return 2001 <= Year && Year <= 2100;
            }
        }


        //4.1.3
        public YearMonth addOneMonth() {
            YearMonth newOne;
            if(this.Month == 12) {
                newOne = new YearMonth(++Year, 1);
            }
            else {
                newOne = new YearMonth(Year, ++Month);
            }
            return newOne;
        }

        //4.1.4
        public override string ToString() {
            return Year + "年" + Month + "月";
        }
    }
      
}
