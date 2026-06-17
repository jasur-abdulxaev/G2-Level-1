namespace N16_T4;

public class Dasturchi : Xodim
{
    public string TilBiladi { get; set; }

    // child construktor - base orqali parent construktorni chaqiradi
    public Dasturchi(string ism, int yosh, string til)
        : base(ism, yosh)
    {
        this.TilBiladi = til;
        Console.WriteLine($"Dasturchi yaratildi: {til} dasturlash tilini biladi.");
    }

    public void IshniKorsat()
    {
        Console.WriteLine($"{Ism} dasturchi - {TilBiladi} dasturlash tilini biladi.");
    }
}
