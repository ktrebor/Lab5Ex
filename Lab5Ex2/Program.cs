using System;

namespace Lab5Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Locomotiva locomotivaDiesel = new Locomotiva(19000, "Electroputere LDE2100");

            Tren accelerat = new Tren("IR2092", locomotivaDiesel);

            VagonDeMarfa marfaPorumb = new VagonDeMarfa("Marfar S204X", 1966, 23000, "porumb", 5000);
            accelerat.AdaugaVagon(marfaPorumb);

            VagonDeMarfa marfaCartofi = new VagonDeMarfa("Marfar Y902B", 1962, 22000, "cartofi", 3500);
            accelerat.AdaugaVagon(marfaCartofi);

            VagonPersoaneClasaUnu navetisti = new VagonPersoaneClasaUnu("Persoane A123P", 1986, 19000, 120);
            accelerat.AdaugaVagon(navetisti);

            VagonPersoane ocazional = new   VagonPersoane("Persoane A36SP", 1988, 18965, 100);
            accelerat.AdaugaVagon(ocazional);

            accelerat.PleacaDinGara();
            accelerat.OpresteInGara();
            Console.WriteLine(locomotivaDiesel.ToString());//primesc valoarea puterii?
            /*
            Console.WriteLine(ocazional.ToString());
            Console.WriteLine(navetisti.ToString());
            Console.WriteLine(marfaPorumb.ToString());
            */
            Console.WriteLine(accelerat.ToString()); //aici la locomotiva, nu primesc valoarea puterii?

        }
    }
}
