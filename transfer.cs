﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_8
{
    internal class Transfer
    {


        public int treshold{ get; set; }
        public int low_fee { get; set; }

        public int high_fee { get; set; }


        public Transfer( int treshold, int low_fee, int high_fee) {
            this.treshold = treshold;
             this.low_fee = low_fee;
            this.high_fee = high_fee;
        
        }
    }
}
