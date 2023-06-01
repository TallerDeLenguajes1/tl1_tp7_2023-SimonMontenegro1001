using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        var calcu = new calculadora();
        calcu.Sumar(1000);
        calcu.Restar(500);
        calcu.Dividir(2);
        calcu.Multiplicar(5);
        Console.WriteLine(calcu.Resultado);
    }
}