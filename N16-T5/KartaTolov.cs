namespace N16_T5;

class KartaTolov : TolovTizimi
{
    public string KartaRaqami { get; set; }

    public KartaTolov(string KartaRaqami)
        : base("Bank kartasi")
    {
        this.KartaRaqami = KartaRaqami;
    }

}
