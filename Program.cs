using Narzedzia_matematyczne_klasa_statyczna;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj km do przeliczenia na mile morkski: ");
        double km = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Podaj temperature C do przeliczenia na F: ");
        double tempC = Convert.ToDouble(Console.ReadLine());

        double mileMorskie = Konwerter.KilometryNaMile(km);
        Console.WriteLine($"{km}km to {mileMorskie} mil morskich.");
        
        double tempF = Konwerter.CelsjuszToFahrenheit(tempC);
        Console.WriteLine($"{tempC}*C to {tempF} fahrenheit.");
    }
}