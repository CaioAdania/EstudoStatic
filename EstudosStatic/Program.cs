/*
Neste caso declaramos tudo com modificador static dentro da Classe principal
*/

using System.Globalization;

internal class Program
{
    static double Pi = 3.14; //a declaração deve ser static pois toda a operação é static
    // ela é declarada fora da main, pois a Circuferencia e o Volume, precisam receber o valor
    static void Main(string[] args)
    {
        Console.Write("Entre o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Circunferencia(raio);
        double volume = Volume(raio);

        Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

    }

    static double Circunferencia(double r) //declaradas static para que possam ser usadas na main
    {
        return 2 * Pi * r;
    }

    static double Volume(double r) //declaradas static para que possam ser usadas na main
    {
        return 4.0 / 3.0 * Pi * Math.Pow(r, 3); // ou r * r * r;
    }
}