namespace N17_T1;

public class Tortburchak : Shakl
{
    public string Rang { get; set; }
    public int Boyi { get; set; }
    public int Eni { get; set; }

    public Tortburchak(string Rang, int Boyi, int Eni)
        : base(Rang)
    {
        this.Boyi = Boyi;
        this.Eni = Eni;
        this.Rang = Rang;
    }

    public void Yuzasi()
    {
        Console.WriteLine($"Rangi: {Rang}, Yuzasi: {Boyi * Eni}");
    }
}

