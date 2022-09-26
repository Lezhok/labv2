class Converter
{
    public double grn = 1000;
    public double usd = 300;
    public double eur = 400;
    public double pln = 700;
    public Converter(double usdx, double eurx, double plnx)
    {
        usdx = usd;
        eurx = eur;
        plnx = pln;
    }
    public void Conver()
    {
        double grn_in_dol = Math.Round(grn / 36.6, 2);

        double grn_in_eur = Math.Round(grn / 35.7, 2);

        double grn_in_pln = Math.Round(grn * 0.13, 2);

        double dol_in_grn = Math.Round(usd * 36.6, 2);

        double eur_in_grn = Math.Round(eur * 35.7, 2);

        double pln_in_grn = Math.Round(pln / 0.13, 2);

        Console.WriteLine($"Ви маєте {grn} гривень");

        Console.WriteLine($"Це {grn_in_dol} доларів");

        Console.WriteLine($"Це {grn_in_eur} евро");

        Console.WriteLine($"Це {grn_in_pln} польських злотих");

        Console.WriteLine($"Ви маєте {usd} доларів. Це {dol_in_grn} гривень");

        Console.WriteLine($"Ви маєте {eur} евро. Це {eur_in_grn} гривень");

        Console.WriteLine($"Ви маєте {pln} польських злотих. Це {pln_in_grn} гривень");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter solution\n");

            Converter ezConverter = new Converter(36.6, 35.7, 0.13);

            ezConverter.Conver();

            Console.ReadKey();
        }
    }
}