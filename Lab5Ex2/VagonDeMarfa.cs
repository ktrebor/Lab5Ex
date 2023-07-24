using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex2
{
    class VagonDeMarfa : Vagon
    {
        protected string tipMarfa { get; set; }
        protected int capacitateIncarcare { get; set; }

        public VagonDeMarfa(string serieVagon, int anFabricatie, int masaVagon, string tipMarfa, int capacitateIncarcare) :base(serieVagon, anFabricatie, masaVagon)
        {
            this.tipMarfa = tipMarfa;
            this.capacitateIncarcare = capacitateIncarcare;
        }

        public override string ToString()
        {
            return $"Vagon de marfa. Tip marfa {tipMarfa}. Cantitatea marfii {capacitateIncarcare}. Anul fabricatiei: {anFabricatie}";
        }

    }
}
