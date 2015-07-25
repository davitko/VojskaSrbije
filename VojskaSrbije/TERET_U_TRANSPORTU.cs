using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VojskaSrbije
{
    public class TERET_U_TRANSPORTU
    {
        public int teretTransportID;
        public int teretID;
        public int transportID;
        public double kolicina;
        public String mernaJedinica;
        public int brojJedinicaPakovanja;
        public String vrstaPakovanja;

        public TERET_U_TRANSPORTU(double kolicina, String mernaJedinica, int brojJedinicaPakovanja, String vrstaPakovanja)
        {
            this.kolicina = kolicina;
            this.mernaJedinica = mernaJedinica;
            this.brojJedinicaPakovanja = brojJedinicaPakovanja;
            this.vrstaPakovanja = vrstaPakovanja;
        }
    }
}
