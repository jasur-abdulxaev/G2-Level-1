namespace N12_HT1;

public class Telefon
{
    public string Model;
    public double Narxi;
    public string Rangi;

    public void MalumotChopEt()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Narxi: {Narxi}");
        Console.WriteLine($"Rangi: {Rangi}");
    }

}
