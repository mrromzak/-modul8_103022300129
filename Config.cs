using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_8
{
    internal class Config
    {

        public string lang { get; set; }

        public Transfer transfer { get; set; }

        public List<string> methods { get; set; }

        public Confirmation confirmation { get; set; }

        public Config() { }

        public Config (string lang, Transfer transfer, List<String> methods, Confirmation confirmation) { 
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
           this.confirmation = confirmation;
        }
             
    }
}
