namespace SomandoValores;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número");
        var valor1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro número");
        var valor2 = Double.Parse(Console.ReadLine());

        Console.WriteLine($"Os numeros são {valor1} e {valor2}");

        var soma = CalularValores.Soma(valor1: valor1, valor2: valor2);
        Console.WriteLine($"A soma dos dois numeros é: {soma}");

        var subtracao = CalularValores.Subtracao(valor1: valor1, valor2: valor2);
        Console.WriteLine($"A subtracao dos dois numeros é: {subtracao}");

        var multiplicacao = CalularValores.Multiplicacao(valor1: valor1, valor2: valor2);
        Console.WriteLine($"A multiplicação dos dois numeros é: {multiplicacao}");

        var divisao = CalularValores.Divisao(valor1: valor1, valor2: valor2);
        Console.WriteLine($"A divisao dos dois numeros é: {divisao}");

        var media = CalularValores.Media(valor1: valor1, valor2: valor2);
        Console.WriteLine($"A media dos dois numeros é: {media}");
    }
}