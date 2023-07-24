using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex2
{
    class VagonPersoane : Vagon
    {
        protected int numarLocuri;

        public VagonPersoane(string serieVagon, int anFabricatie, int masaVagon, int numarLocuri) : base(serieVagon, anFabricatie, masaVagon)
        {
            this.numarLocuri = numarLocuri;
        }

        public void InchideUsile()
        {
            Console.WriteLine("Atentie se inchid usile");
        }

        public void DeschideUsile()
        {
            Console.WriteLine("Atentie se deschid usile");
        }

        public override string ToString()
        {
            return $"Vagon de persoane. Numar locuri {numarLocuri}. Anul fabricatiei {anFabricatie}. Masa vagon: {masaVagon}";
        }
    }
}
