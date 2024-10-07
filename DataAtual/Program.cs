namespace DataAtual;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data (dd/MM/yyyy)");
        Console.WriteLine("3 - Apenas a hora (formato de 24 horas)");
        Console.WriteLine("4 - A data com o mês por extenso");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                string formatoCompleto = dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR"));
                Console.WriteLine($"Data completa: {formatoCompleto}");
                break;

            case "2":
                string apenasData = dataAtual.ToString("dd/MM/yyyy");
                Console.WriteLine($"Apenas a data: {apenasData}");
                break;

            case "3":
                string apenasHora = dataAtual.ToString("HH:mm:ss");
                Console.WriteLine($"Apenas a hora: {apenasHora}");
                break;

            case "4":
                string dataMesPorExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
                Console.WriteLine($"Data com mês por extenso: {dataMesPorExtenso}");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}

