

public struct Dane
{
    public string nazwaZespolu { set; get; }
    public string tytulAlbumu { set; get;  }
    public int liczbaUtworow { set; get; }
    public long liczbaPobran { set; get; }

    public Dane(string nazwaZespolu, string tytulAlbumu, int liczbaUtworow, long liczbaPobran)
    {
        this.nazwaZespolu = nazwaZespolu;
        this.tytulAlbumu = tytulAlbumu;
        this.liczbaUtworow = liczbaUtworow;
        this.liczbaPobran = liczbaPobran;
    }
}


class Program
{
    static string[] pobierzDane()
    {
        string sciezkaPliku = "../../../Data.txt";
        string[] linie = File.ReadAllLines(sciezkaPliku);
        
        return linie;

    }
    
    static void wyswietlDane(string[] linie)
    {
        foreach (string linia in linie)
        {
            Console.WriteLine(linia);
        }
    }
    
    
    static void Main(string[] args)
    {
        string[] linie = pobierzDane();
        wyswietlDane(linie);
    }
}