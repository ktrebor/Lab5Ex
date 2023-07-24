using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex2
{
    class Vagon
    {
        protected string serieVagon { get; set; }
        protected int anFabricatie { get; set; }
        protected int masaVagon { get; set; }

        public Vagon(string serieVagon, int anFabricatie, int masaVagon)
        {
            this.serieVagon = serieVagon;
            this.anFabricatie = anFabricatie;
            this.masaVagon = masaVagon;
        }
    }
}
