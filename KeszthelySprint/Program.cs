namespace KeszthelySprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new();

            foreach (var sor in File.ReadAllLines("eredmenyek.txt"))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"2.Feladat: \t A Versenyt {versenyzok.Count()} versenyző fejezte be");

            int junior = 0;

            foreach (var j in versenyzok)
            {
                if (j.Kategoria == "elit junior")
                {
                    junior += 1;
                }
            }
            Console.WriteLine($"3.Feladat \t A versnyzők száma Az \"elit junior\" kategóriában: {junior} Fő");

            int atlag = 0;
            foreach (var s in versenyzok)
            {
                atlag += DateTime.Now.Year - s.Szuletes;
            }
            Console.WriteLine($"4. feladat \t Az átlag életkor: {atlag / versenyzok.Count():0.0} év");
        }
    }
}
