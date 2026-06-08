namespace N13_T1;

//class yaratish
public class Telefon
{
    // fieldlari
    public string Model;
    public double Narxi;
    public string Rangi;

    // methodlari
    public void MalumotChiqar()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Narxi: {Narxi}");
        Console.WriteLine($"Rangi: {Rangi}");
    }
}

