namespace ConcatenandoStrings;

class Program
{
    static void Main()
    {
        /*
         Crie um programa que concatene um nome e um 
         sobrenome inseridos pelo usuário e ao final exiba o nome completo.
         */
        Console.Write("Digite seu primeiro nome: ");
        var nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome completo é {nome} {sobrenome}");
    }

}
