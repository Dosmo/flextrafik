using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Firma
    {
        public string CVR { get; set; }
        public string AndetNavn { get; set; }
        public string Navn { get; set; }
        public Firma(string CVR = "", string AndetNavn = "", string Navn = "")
        {
            this.CVR = CVR;
            this.AndetNavn = AndetNavn;
            this.Navn = Navn;
        }
    }
}
