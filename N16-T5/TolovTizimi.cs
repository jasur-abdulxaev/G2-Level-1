namespace N16_T5;

// Abstrakt class - voris olib bo'lmaydigan class
abstract class TolovTizimi
{
    public string Nomi { get; set; }

    public TolovTizimi(string nomi)
    {
        this.Nomi = nomi;
    }

    public abstract bool TolovQil(decimal summa, string kimga);

    public void NatijaYoz(decimal summa, bool natija)
    {
        string holat = natija ? "Muvaffaqqiyatli!" : "XATO";
        Console.WriteLine($"[{Nomi} {summa:C} --> {holat}]");
    }
}
