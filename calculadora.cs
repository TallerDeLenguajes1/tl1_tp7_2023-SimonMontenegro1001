
namespace EspacioCalculadora
{
    class calculadora
    {
        private double dato;

        public calculadora()
        {
        }

        public double Resultado { get => dato;  }

        public void Sumar(double termino) 
        {
            dato += termino; 
        }
        public void Restar(double termino) 
        {
            dato -= termino; 
        }
        public void Multiplicar(double termino) 
        {
            dato *= termino; 
        }
        public void Dividir(double termino) 
        {
            dato /= termino; 
        }

    }
}