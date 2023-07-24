using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex2
{
    class Tren
    {
        public string nume { get; set; }
        public List<Vagon> listaVagoane = new List<Vagon>();
        private Locomotiva locomotiva;

        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = new Locomotiva();
        }

        public void AdaugaVagon(Vagon vagon)
        {
            if (!listaVagoane.Contains(vagon))
            {
                listaVagoane.Add(vagon);
            }
        }

        public void PleacaDinGara()
        {
            foreach(Vagon vagon in listaVagoane)
            {
                if (vagon is VagonPersoane)
                {
                    VagonPersoane vp = vagon as VagonPersoane;
                    vp.InchideUsile();
                } 
            }
            locomotiva.Porneste();
        }

        public void OpresteInGara()
        {
            locomotiva.Opreste();
            foreach (Vagon vagon in listaVagoane)
            {
                if (vagon is VagonPersoane)
                {
                    VagonPersoane vp = vagon as VagonPersoane;
                    vp.DeschideUsile();
                }
                if (vagon is VagonPersoaneClasaUnu)
                {
                    VagonPersoaneClasaUnu vpunu = vagon as VagonPersoaneClasaUnu;
                    vpunu.OpresteAer();
                }
            }
            
        }
    }
}
