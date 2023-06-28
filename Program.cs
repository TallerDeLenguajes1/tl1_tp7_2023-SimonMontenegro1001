using EspacioCalculadora;
internal class Program
{
    private static void Main(string[] args)
    {
        var calcu = new calculadora();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("uwu CALCULADORA uwu");
            Console.WriteLine("Ingrese una operación (+, -, /, *) seguida de un número, o 'limpiar' para formatear y 'salir' para salir:");

            Console.WriteLine("Resultado = " + calcu.Resultado);
            string entrada = Console.ReadLine()?.ToLower()?.Replace(" ", "");
            if (entrada == "salir")
            {
                break;
            }
            else if (entrada == "limpiar")
            {
                calcu.Limpiar();
                Console.WriteLine("Calculadora formateada.");
            }
            else if (entrada.Length >= 2)
            {
                char operador = entrada[0];
                string numeroStr = entrada.Substring(1);

                if (int.TryParse(numeroStr, out int numero))
                {
                    switch (operador)
                    {
                        case '+':
                            calcu.Sumar(numero);
                            break;
                        case '-':
                            calcu.Restar(numero);
                            break;
                        case '*':
                            calcu.Multiplicar(numero);
                            break;
                        case '/':
                            if (numero != 0)
                            {
                                calcu.Dividir(numero);
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede dividir entre cero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Operador inválido.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }

        }

        Console.WriteLine("RESULTADO FINAL: " + calcu.Resultado);
    }
}