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



        }
    }
}