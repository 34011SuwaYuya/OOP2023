﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    public class CityInfo {
        public string City { get; set; }
        public int Population { get; set; }

        //public CityInfo(string city, int population) {
        //    City = city;
        //    Population = population;
        //}

        //キー値はoverrideの必要性があるが、バリューは必要ない
        //public override bool Equals(object obj) {

        //    var other = obj as CityInfo;
        //    if (other == null) {
        //        throw new ArgumentException();
        //    }

        //    return this.City == other.City;
        //}

        //public override int GetHashCode() {
        //    return City.GetHashCode() * 31;
        //}
    }
    
}
