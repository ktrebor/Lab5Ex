using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex2
{
    class VagonPersoaneClasaUnu : VagonPersoane
    {
        public VagonPersoaneClasaUnu(string serieVagon, int anFabricatie, int masaVagon, int numarLocuri) : base(serieVagon, anFabricatie, masaVagon, numarLocuri)
        {
        }

        public void PornesteAer()
        {
            Console.WriteLine("Am pornit aerul conditionat");
        }

        public void OpresteAer()
        {
            Console.WriteLine("Am oprit aerul conditionat");
        }
    }
}
