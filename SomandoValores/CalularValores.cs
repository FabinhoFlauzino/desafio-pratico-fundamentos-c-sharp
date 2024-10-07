namespace SomandoValores;

class CalularValores
{
    public static double Soma(double valor1, double valor2)
    {
        return valor1 + valor2;
    }

    public static double Subtracao(double valor1, double valor2)
    {
        return valor1 - valor2;
    }

    public static double Multiplicacao(double valor1, double valor2)
    {
        return valor1 * valor2;
    }

    public static double Divisao(double valor1, double valor2)
    {
        if(valor1 == 0 || valor2 == 0) return 0;

        return valor1 / valor2;
    }

    public static double Media(double valor1, double valor2)
    {
        var media = (valor1 + valor2) / 2;

        return media;
    }
}
