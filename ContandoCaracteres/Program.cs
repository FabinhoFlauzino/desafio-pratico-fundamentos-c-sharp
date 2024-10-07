namespace ContandoCaracteres;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras:");
        var input = Console.ReadLine(); 

        int contador = 0;

        foreach (char c in input)
        {
            if (!char.IsWhiteSpace(c))
            {
                contador++;
            }
        }

        Console.WriteLine($"A quantidade de caracteres (sem contar espaços) é: {contador}");
    }
}
