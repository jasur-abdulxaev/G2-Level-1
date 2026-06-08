namespace N13_T3;

public class Futbolchi
{

    public string Ism;
    public string Jamoa;
    public int GollarSoni;

    // Methodlar 
    public void MalumotChiqar()
    {
        Console.WriteLine($"Ism: {Ism}, Jamoa: {Jamoa}, Gollar Soni: {GollarSoni}");
    }

    public void GolUrish(int golSoni)
    {
        GollarSoni += golSoni;
        Console.WriteLine($"{golSoni} ta gol urdi. Jami: {GollarSoni}");
    }

    public string DarajaAniqla()
    {
        if (GollarSoni >= 15) return "Yulduz Futbolchi";
        else if (GollarSoni >= 8) return "Tajribali Futbolchi";
        else return "Yangi Futbolchi";
    }
}
