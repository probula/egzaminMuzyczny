

public struct Dane
{
    public string nazwaZespolu { set; get; }
    public string tytulAlbumu { set; get;  }
    public int liczbaUtworow { set; get; }
    public int rokWydania { set; get; }
    public long liczbaPobran { set; get; }

    public Dane(string nazwaZespolu, string tytulAlbumu,
        int liczbaUtworow, int rokWydania, long liczbaPobran)
    {
        this.nazwaZespolu = nazwaZespolu;
        this.tytulAlbumu = tytulAlbumu;
        this.liczbaUtworow = liczbaUtworow;
        this.rokWydania = rokWydania;
        this.liczbaPobran = liczbaPobran;
    }
}


class Program
{
    static Dane[] pobierzDane()
    {
        string sciezkaPliku = "../../../Data.txt";
        string[] linie = File.ReadAllLines(sciezkaPliku);
        
        

        List<Dane> rekordy = new List<Dane>();
        List<string> dane = new List<string>();

        foreach (string line in linie)
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                dane.Add(line.Trim());
            }
        }

        for (int i = 0; i+4 < dane.Count; i += 5)
        {
            string nazwaZespolu = dane[i];
            string tytulAlbumu = dane[i + 1];
            int liczbaUtworow = int.Parse(dane[i + 2]);
            int rokWydania = int.Parse(dane[i + 3]);
            long liczbaPobran = int.Parse(dane[i + 4]);
   

            Dane rekord = new Dane(
                nazwaZespolu: nazwaZespolu,
                tytulAlbumu: tytulAlbumu,
                liczbaUtworow: liczbaUtworow,
                rokWydania: rokWydania,
                liczbaPobran: liczbaPobran
            );
            rekordy.Add(rekord);
        }

        return rekordy.ToArray();

    }
    
    static void wyswietlDane(Dane[] rekordy)
    {
        foreach (Dane rekord in rekordy)
        {
            Console.WriteLine(
                $"{rekord.nazwaZespolu}\n {rekord.tytulAlbumu}\n " +
                $"{rekord.liczbaUtworow}\n {rekord.rokWydania}\n " +
                $"{rekord.liczbaPobran}"
            );
        }
    }
    
    
    static void Main(string[] args)
    {
        Dane[] rekordy = pobierzDane();
        wyswietlDane(rekordy);
    }
}