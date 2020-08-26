using System;

namespace Ejercicio07Punto01EnCapas.BL
{
    public class Celsius
    {
        private double grados;

        public double Grados
        {
            get { return grados; }
            set
            {
                if (value<-70 || value>70)
                {
                    throw new Exception("Temperatura fuera de los rangos permitidos");
                }
                grados = value;
            }
        }
        /// <summary>
        /// Método construtor
        /// encargado de crear los objetos de tipo Celsius
        /// </summary>
        public Celsius()
        {

        }

        public Celsius(double tmpCelsius)
        {
            Grados = tmpCelsius;
        }

        public double GetGradosFahrenheit()
        {
            return 1.8 * Grados + 32;
        }

        public double GetGradosReaumur()
        {
            return 0.8 * Grados;
        }
    }
}
