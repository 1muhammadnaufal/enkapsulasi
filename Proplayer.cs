using System;

namespace programenkapsulasi
{
    internal class Proplayer
    {
        // fields
        public string nama;
        public string tim;
        public string role;
        public string turnamen;
        public int umur;
        public int season;

        // constructor
        public Proplayer() { }

        public Proplayer(string nama, string tim, string role, int umur, int season)
        {
            this.nama = nama;
            this.tim = tim;
            this.role = role;
            this.umur = umur;
            this.season = season;
        }


        // method
        public void SetData(string nama, int umur, string tim)
        {
            this.nama = nama;
            this.umur = umur;
            this.tim = tim;
            Console.WriteLine("nama proplayer     : {0}", this.nama);
            Console.WriteLine("umur proplayer     : {0}", this.umur);
            Console.WriteLine("nama tim           : {0}", this.tim);
        }

        public void SetDataRole(string turnamen, string role, int season)
        {
            this.turnamen = turnamen;
            this.role = role;
            this.season = season;
            Console.WriteLine("role               : {0}", this.turnamen);
            Console.WriteLine("hero faforit       : {0}", this.role);
            Console.WriteLine("season main        : {0}", this.season);
            Console.ReadKey();
        }
    }
}
