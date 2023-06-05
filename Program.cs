using System;

namespace programenkapsulasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program data proplayer mlbb");
            Console.WriteLine("===========================");

            Proplayer proplayer1 = new Proplayer();
            Proplayer proplayer2 = new Proplayer();
            Proplayer proplayer3 = new Proplayer();

            proplayer1.SetData("Lemon", 24, "RRQ Hoshi");
            proplayer1.SetDataRole("MidLaner", "kagura", 1);
            Console.WriteLine();

            proplayer2.SetData("King Branz bin Jabran", 21, "Evos legend");
            proplayer2.SetDataRole("GoldLaner", "Karie", 4);
            Console.WriteLine();

            proplayer3.SetData("Celiboy", 22, "Alter Ego");
            proplayer3.SetDataRole("Jungler", "Baxilit", 3);
            Console.WriteLine();
        }
    }
}
