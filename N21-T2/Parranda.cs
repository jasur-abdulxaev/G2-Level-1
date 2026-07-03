namespace N21_T2;

public class Parranda : IUchuvchi, ISuzuvchi
{
    public void Suz()
    {
        Console.WriteLine($"Parranda suvda suzadi!");
    }

    public void Uch()
    {
        Console.WriteLine($"Parranda uchadi!");
    }
}
