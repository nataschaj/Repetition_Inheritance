using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionInheritance
{
    public class Bil
    {
        public int BilPrisExAfgift { get; set; }
        public int KøbsÅr { get; set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }

        public Bil()
        {
            this.KøbsÅr = 2016;
            this.Mærke = "Audi";
            this.BilPrisExAfgift = 100;
            this.KmPrLiter = 600;
        }

        public virtual int RegistreringsAfgift()
        {
            
        }

        public int TotalPris()
        {

        }

        public int HalvÅrligEjerafgift()
        {
            return 1000;
        }
    }
}
