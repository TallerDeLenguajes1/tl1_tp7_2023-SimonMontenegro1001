
namespace EspacioEmpleado
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaDeNac;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private cargos cargo;

        public Empleado(string nombre, string apellido, DateTime fechaDeNac, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, cargos cargo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaDeNac = fechaDeNac;
            this.estadoCivil = estadoCivil;
            this.genero = genero;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargo = cargo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaDeNac { get => fechaDeNac; set => fechaDeNac = value; }
        public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public char Genero { get => genero; set => genero = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public cargos Cargo { get => cargo; set => cargo = value; }

        public double salario()
        {
            double adicional = 0;
            if (Antiguedad() < 20)
            {
                adicional = Antiguedad() * SueldoBasico / 100;
            }
            else
            {
                adicional = 25 * SueldoBasico / 100;
            }

            if (cargo == cargos.Ingeniero || cargo == cargos.Espacialista)
            {
                adicional *= 1.5;
            }

            if (estadoCivil == 'c')
            {
                adicional += 15000;
            }
            return SueldoBasico + adicional;
        }
        public int AniosParaJubilarse()
        {
            if (genero == 'm')
            {
                return 60 - Edad();
            }
            else if (genero == 'v')
            {
                return 65 - Edad();
            }
            else
            {
                return -1;
            }
        }
        public int Antiguedad()
        {
            var hoy = DateTime.Now;
            return hoy.Year - FechaIngreso.Year;
        }
        public int Edad()
        {
            var hoy = DateTime.Now;
            var edad = hoy.Year - FechaDeNac.Year;
            if (hoy.Month < FechaDeNac.Month || (hoy.Month == FechaDeNac.Month && hoy.Day < FechaDeNac.Day))
            {
                edad--;
            }

            return edad;
        }
    }

    public enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Espacialista,
        Investigado

    }
}