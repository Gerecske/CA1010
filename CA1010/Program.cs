namespace CA1010
{
    public class Allat
    {
        public string Nev { get; set; }
        public float Suly { get; private set; } = 0f;

        public virtual string HangotAdKi() => "valami - valami";

        public void Taplalkozik(float kgKaja) => Suly += kgKaja;


    }

    public class Macska : Allat
    {
        public int EletekSzama { get; set; } = 9;

        public new string HangotAdKi() => "miaú - miaú";
    }

    public class Kutya : Allat
    {
        public bool Huseg { get; set; } = true;

        public override string HangotAdKi()
        {
            return "vau - vau";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region jegyzet
            // ENCAPSULATION
            // - logikailag összetartozó dolgok (fields, metods) egy egységbe vannak zárva
            // - helyes állapotért ez az egység felelős 
            // INHERITANCE
            // - elsősorban az psztályok "továbbfejleszthetőség"ének lehetősége
            // - a child class örököl mindent a parent-ről
            // - el tudja fedni az eredeti metódust, ha azonos a fejléce
            // POLIMORFISM
            // - az ősosztály példányai képesek asználni a gyermekosztály metódusait is,
            // megfelelő körülmények között
            // (késői kötés)
            #endregion

            Allat allat = new Allat()
            {
                Nev = "Gertrúd",

            };

            Macska macska = new Macska()
            {
                Nev = "Lukrécia",
                EletekSzama = 7,
            };


            Kutya kutya = new Kutya()
            {
                Nev = "Frakk",
            };

            Console.WriteLine($"{allat.Nev} mondja: {allat.HangotAdKi()}");
            Console.WriteLine($"{macska.Nev} mondja: {macska.HangotAdKi()}");
            Console.WriteLine($"{kutya.Nev} mondja: {kutya.HangotAdKi()}");

            List<Allat> allatok = new List<Allat>();

            allatok.Add(allat);
            allatok.Add(macska);
            allatok.Add(kutya);

            foreach (Allat a in allatok)
            {
                Console.WriteLine($"{a.Nev} mondja: {a.HangotAdKi()}");

                if (a is Macska)
                {
                    Console.WriteLine((a as Macska).HangotAdKi());
                }
            }

            Allat valami = new Kutya();
        }
    }
}