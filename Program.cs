using EspacioEmpleado;
internal class Program
{
    private static void Main(string[] args)
    {
        Empleado[] empleados = new Empleado[4];

        empleados[0] = new Empleado("Juan", "Pérez", new DateTime(1990, 5, 10), 's', 'v', new DateTime(2020, 1, 1), 2500, cargos.Ingeniero);
        empleados[1] = new Empleado("María", "Gómez", new DateTime(1985, 8, 20), 'c', 'm', new DateTime(2018, 3, 15), 3000, cargos.Espacialista);
        empleados[2] = new Empleado("Carlos", "López", new DateTime(1995, 12, 3), 'c', 'v', new DateTime(2019, 6, 5), 2000, cargos.Auxiliar);
        empleados[3] = new Empleado("Franco", "Rodriguez", new DateTime(1990, 1, 1), 'c', 'm', new DateTime(2008, 1, 1), 65000, cargos.Espacialista);
        System.Console.WriteLine("Monto que se le pagara a lso empleados: ");
        int prox = 100;
        string nombreProx = "";
        foreach (var empleado in empleados)
        {
            System.Console.WriteLine("Al empleado " + empleado.Apellido + " " + empleado.Nombre + " de " + empleado.Edad() + " anios se le pagara: " + empleado.salario());
            System.Console.WriteLine("antiguedad = " + empleado.Antiguedad());
            System.Console.WriteLine("anios para jubilarse = " + empleado.AniosParaJubilarse());
            if (empleado.AniosParaJubilarse() < prox)
            {
                prox = empleado.AniosParaJubilarse();
                nombreProx = empleado.Nombre + " " + empleado.Apellido;
            }
        }
        System.Console.WriteLine("el empleado proximo a jubilarse es: " + nombreProx);
    }
}