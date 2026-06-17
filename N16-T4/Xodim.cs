namespace N16_T4;

public class Xodim
{
    public string Ism { get; set; }
    public int Yosh { get; set; }

    // Parent construktor
    public Xodim(string Ism, int Yosh)
    {
        this.Ism = Ism;
        this.Yosh = Yosh;
        Console.WriteLine($"Xodim yaratildi: {Ism}");
    }

    public void MalumotKorsat()
    {
        Console.WriteLine($"[Xodim] {Ism}, {Yosh} yosh.");
    }
}
