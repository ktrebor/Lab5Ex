using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5Ex
{
    class Elev
    {
        private string numeElev;
        private string prenumeElev;
        private List<int> listaNote;

        public Elev(string numeElev, string prenumeElev)
        {
            this.numeElev = numeElev;
            this.prenumeElev = prenumeElev;
            listaNote = new List<int>();
        }

        public string NumeElev
        {
            get { return numeElev; }
        }

        public string PrenumeElev
        {
            get { return prenumeElev; }
        }

        public void AdaugaNota(int nota)
        {
            listaNote.Add(nota);
        }

        public string GetDescriere()
        {
            StringBuilder descriere = new StringBuilder();
            descriere.Append($"Numele complet: {prenumeElev} {numeElev}.");
            descriere.Append($"\nNote: ");

            if (listaNote.Count > 0)
            {
                foreach (var nota in listaNote)
                {
                    descriere.Append($"{nota} ");
                }
            }
            else
            {
                descriere.Append("Nu are note ");
            }

            return descriere.ToString();
        }

        public double CalculeazaMediaNote()
        {
            if (listaNote.Count > 0)
            {
                int suma = 0;
                foreach (int nota in listaNote)
                {
                    suma += nota;
                }

                return (double)suma/listaNote.Count;
            }
            else
            {
                return 0;
            }
        }
    }
}
