namespace _5M08konPlytyMuzyczne
{
    class Plyta
    {
        public string wykonawca;
        public string tytul;
        public int liczbaUtworow;
        public int rokWydania;
        public long liczbaPobran;
        public override string ToString()
        {
            string s = wykonawca + "\n" + tytul + "\n";
            s += liczbaUtworow.ToString() + "\n";
            s += rokWydania.ToString() + "\n";
            s += liczbaPobran.ToString() + "\n";
            return s;
        }
    }
    internal class Program
    {
        private static List<Plyta> plyty = new List<Plyta>();
        static void Main(string[] args)
        {
            
            wczytajDane();
            wypiszDane();
        }
        private static void wczytajDane()
        {
            string wiersz;
            
            using (FileStream plik = File.OpenRead("Data.txt"))
                using(TextReader reader = new StreamReader(plik))
                {
                    while(true)
                    {
                        Plyta plyta = new Plyta();
                        wiersz = reader.ReadLine();
                        if (wiersz == null || wiersz.Length == 0)
                            break;
                        plyta.wykonawca = wiersz;
                        plyta.tytul = reader.ReadLine();
                        plyta.liczbaUtworow = int.Parse(reader.ReadLine()); 
                        plyta.rokWydania = int.Parse(reader.ReadLine());
                        plyta.liczbaPobran = long.Parse(reader.ReadLine());
                        plyty.Add(plyta);
                        wiersz = "";
                    }

                }

        }
        private static void wypiszDane()
        {
            foreach(var plyta in plyty)
                Console.WriteLine(plyta);
            Console.WriteLine();
        }
    }
}
