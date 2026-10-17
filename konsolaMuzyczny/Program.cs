

public struct Dane
{
    public string nazwaZespolu { get; set; }
    public string tytulAlbumu { get; set; }
    public int liczbaUtworow { get; set; }
    public int rokWydania { get; set; }
    public long liczbaPobran { get; set; }

    public Dane(string nazwaZespolu, string tytulAlbumu, int liczbaUtworow, int rokWydania, long liczbaPobran)
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

    public static List<Dane> odczytajDane()
    {
        var sciezka = "../../../Data.txt";
        string[] tablicaLinijkaPliku = File.ReadAllLines(sciezka);
        List<Dane> listaRekordow = new List<Dane>();

        for (int i = 0; i < tablicaLinijkaPliku.Length; i += 6) // 5 lini danych + 6 linia odstepu
        {
            if (string.IsNullOrEmpty(tablicaLinijkaPliku[i]))
            {
                continue;
            }

            if (i + 4 < tablicaLinijkaPliku.Length)
            {
                Dane dane = new Dane();
                dane.nazwaZespolu = tablicaLinijkaPliku[i];
                dane.tytulAlbumu = tablicaLinijkaPliku[i + 1];
                dane.liczbaUtworow = int.Parse(tablicaLinijkaPliku[i + 2]);
                dane.rokWydania = int.Parse(tablicaLinijkaPliku[i + 3]);
                dane.liczbaPobran = int.Parse(tablicaLinijkaPliku[i + 4]);
                
                listaRekordow.Add(dane);
            }
            
        }
        
        return listaRekordow;


    }

    public static void wyswietlDane(List<Dane> lista)
    {
        foreach (var rekord in lista)
        {
            Console.WriteLine(rekord.nazwaZespolu);
            Console.WriteLine(rekord.tytulAlbumu);
            Console.WriteLine(rekord.liczbaUtworow);
            Console.WriteLine(rekord.rokWydania);
            Console.WriteLine(rekord.liczbaPobran);
        }
    }
    
    static void Main(string[] args)
    {
        List<Dane> rekordy = odczytajDane();
            
        wyswietlDane(rekordy);

    }
}