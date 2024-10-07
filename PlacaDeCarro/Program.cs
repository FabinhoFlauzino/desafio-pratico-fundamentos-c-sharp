
namespace PlacaDeCarro;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a placa do veículo:");
        var placa = Console.ReadLine();

        var padraoPlaca = @"^[a-zA-Z]{3}[0-9]{4}$";

        var placaValida = Regex.IsMatch(placa, padraoPlaca);

        if (placaValida)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }
}
