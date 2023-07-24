using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex2
{
    class Locomotiva
    {
        private int putere { get; set; }
        private string serieLocomotiva { get; set; }

        public Locomotiva()
        {
        }

        public Locomotiva(int putere, string serieLocomotiva)
        {
            this.putere = putere;
            this.serieLocomotiva = serieLocomotiva;
        }

        public void Porneste()
        {
            Console.WriteLine("Am pornit locomotiva");
        }

        public void Opreste()
        {
            Console.WriteLine("Am oprit locomotiva");
        }

        public override string ToString()
        {
            return $"Putere locomotiva: {putere} kW";
        }
    }
}
