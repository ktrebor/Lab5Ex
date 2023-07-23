using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex
{
    class Catalog
    {
        public string numeClasa;
        private List<Elev> listaElevi = new List<Elev>();

        public Catalog(string numeClasa)
        {
            this.numeClasa = numeClasa;
            listaElevi = new List<Elev>();
        }

        public void AdaugaElev(Elev elev)
        {
            if (!listaElevi.Contains(elev))
            {
                listaElevi.Add(elev);
            }
        }

        public void StergeElev(Elev elev)
        {
            listaElevi.Remove(elev);
        }

        public string GetDescriere()
        {    
            string result = $"Catalog: {numeClasa}\n";

            foreach (Elev elev in listaElevi)
            {
                result += elev.GetDescriere() + "\n";
            }

            return result; 
        }

        public string GetPremiant()
        {
            if (listaElevi.Count > 0)
            {
                Elev premiant = listaElevi[0];
                double mediaCeaMaiMare = premiant.CalculeazaMediaNote();

                foreach(Elev elev in listaElevi)
                {
                    double media = elev.CalculeazaMediaNote();
                    if (media > mediaCeaMaiMare)
                    {
                        premiant = elev;
                        mediaCeaMaiMare = media;
                    }
                }

                return "Premiant: " + premiant.NumeElev + " " + premiant.PrenumeElev;
             }
            
            else
            {
                return "Nu sunt elevi!";
            }
        }
    }
}
