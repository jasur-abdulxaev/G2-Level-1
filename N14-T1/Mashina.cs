namespace N14_T1;

public class Mashina
{
    // fieldlari
    public string Brend;
    public string Model;
    public int Yil;

    // construktor
    public Mashina(string Brend, string Model, int Yil)
    {
        this.Brend = Brend;
        this.Model = Model;
        this.Yil = Yil;
    }

    public void MalumotChiqar()
    {
        Console.WriteLine($"Brend: {Brend}, Model: {Model}, Yil: {Yil}");
    }
}
