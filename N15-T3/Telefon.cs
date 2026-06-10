namespace N15_T3;

class Telefon
{
    // fieldlar
    private string _modeli;
    private double _narxi;
    private int _batareyaFoizi;

    // construktori
    public Telefon(string modeli, double narxi, int batareyaFoizi)
    {
        this._modeli = modeli;
        this._narxi = narxi;
        this._batareyaFoizi = batareyaFoizi;
    }

    public string Modeli
    {
        get { return _modeli; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Xato: Telefon modeli bo'sh bo'lishi mumkin emas.");
                return;
            }
            _modeli = value;
        }
    }

    public double Narx
    {
        get { return _narxi; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Xato: Telefon narxi manfiy bo'lishi mumkin emas.");
                return;
            }
            _narxi = value;
        }
    }

    public int BatareyaFoizi
    {
        get { return _batareyaFoizi; }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Xato: Batareya foizi 0 dan 100 gacha bo'lishi kerak.");
                return;
            }
            _batareyaFoizi = value;
        }
    }
}
