

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
    static void Main(string[] args)
    {
        string sciezkaPliku = "../../../Data.txt";
        
        string[] linie = File.ReadAllLines(sciezkaPliku);
        
        List<Dane> listaAlbumow = new List<Dane>();

        foreach (string linia in linie)
        {
            Console.WriteLine(linia);
        }
    }
}