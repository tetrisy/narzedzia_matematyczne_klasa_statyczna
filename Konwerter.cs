namespace Narzedzia_matematyczne_klasa_statyczna;

public static class Konwerter
{
    public const double LiczbaPi = 3.14;
    public const double PrzelicznikMil = 0.539957;

    public static double CelsjuszToFahrenheit(double celsjusz)
    {
        return Math.Round(celsjusz * 9.0 / 5.0 + 32, 2);
    }

    public static double KilometryNaMile(double kilometry)
    {
        return Math.Round(kilometry * PrzelicznikMil, 2);
    }
    
}