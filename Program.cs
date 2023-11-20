using Console_Berek2020.DataSource;

namespace Console_Berek2020
{
    internal class Program
    {
        static List<Ber> berek = new List<Ber>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(".\\DataSource\\berek2020.txt");

            sr.ReadLine(); // fejlécsor beolvasása

            while (!sr.EndOfStream) 
            {
                string[] line = sr.ReadLine().Split(";");

                Ber adatsor = new Ber(
                    line[0],
                    line[1],
                    line[2],
                    int.Parse(line[3]),
                    double.Parse(line[4])
                    );

                berek.Add(adatsor);

            }

            sr.Close();

            // 3. feladat

            Console.WriteLine($"3. feladat: Dolgozók száma: {berek.Count()} fő");

            // 4. feladat

            Console.WriteLine($"4. feladat: Bérek átlaga: {Math.Round(berek.Average(x => x.Fizetes/1000),1)} eFt");

            // 5. feladat 

            Console.Write("Kérem egy részleg nevét: ");
            string reszlegNeve = Console.ReadLine();

            // 6. feladat

            Console.WriteLine("A legtöbbet kereső dolgozó a megadott részlegen");

            if (berek.Any(x => x.Reszleg == reszlegNeve))
            {
                var maxBer = berek.OrderByDescending(x => x.Fizetes).Where(x => x.Reszleg == reszlegNeve).First();
                Console.WriteLine($"\tNév: {maxBer.Nev}");
                Console.WriteLine($"\tNeme: {maxBer.Neme}");
                Console.WriteLine($"\tBelépés éve: {maxBer.BelepesEve}");
                Console.WriteLine($"\tBér: {maxBer.Fizetes}");

            }
            else
            {
                Console.WriteLine("A megadott részleg nem létezik a cégnél!");
            }

            // 7. feladat

            Console.WriteLine("7. feladat: Statisztika: ");

            Dictionary<string, int> statisztika = berek.GroupBy(x => x.Reszleg).ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in statisztika)
            {
                Console.WriteLine($"\t {item.Key} - {item.Value} fő");
            }
        }
    }
}