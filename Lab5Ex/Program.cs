using System;

namespace Lab5Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elev ion = new Elev("Popescu", "Ion");
            Elev maria = new Elev("Tudoran", "Maria");
            Elev tudor = new Elev("Albert", "Tudor");
            Catalog bioChimie = new Catalog("Biologie-Chimie");

            bioChimie.AdaugaElev(ion);
            bioChimie.AdaugaElev(maria);
            bioChimie.AdaugaElev(tudor);

            ion.AdaugaNota(9);
            ion.AdaugaNota(7);
            ion.AdaugaNota(7);
            maria.AdaugaNota(8);
            maria.AdaugaNota(8);
            maria.AdaugaNota(10);
            tudor.AdaugaNota(10);
            tudor.AdaugaNota(8);
            tudor.AdaugaNota(7);

            Console.WriteLine(bioChimie.GetPremiant());
            Console.WriteLine(bioChimie.GetDescriere());

            
        }
    }
}
