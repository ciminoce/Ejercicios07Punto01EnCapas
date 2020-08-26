using System.Collections.Generic;
using System.Linq;
using Ejercicio07Punto01EnCapas.BL;

namespace Ejercicio07Punto01EnCapas.DL
{
    public class RepositorioDeTemperaturas
    {
        public List<Celsius> Temperaturas { get; set; }=new List<Celsius>()
        {
            new Celsius(17.7),
            new Celsius(14),
            new Celsius(18.2),
            new Celsius(20),
            new Celsius(19),
            new Celsius(24),
            new Celsius(18.3),
            new Celsius(21)

        };
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public RepositorioDeTemperaturas()
        {
            
        }
        /// <summary>
        /// Método para poder almacenar un elemento en la lista
        /// </summary>
        /// <param name="celsius"></param>
        public void Agregar(Celsius celsius)
        {
            Temperaturas.Add(celsius);
        }
        /// <summary>
        /// Devuelve la cantidad de elementos almacenados en la lista
        /// </summary>
        /// <returns></returns>
        public int GetCantidad()
        {
            return Temperaturas.Count;
        }
        /// <summary>
        /// Método que devuelve la lista de temperaturas almacenadas
        /// </summary>
        /// <returns></returns>
        public List<Celsius> GetLista()
        {
            return Temperaturas;
        }

        public double GetMayorTemperatura()
        {
            return Temperaturas.Max(t => t.Grados);
        }

        public double GetMenorTemperatura()
        {
            return Temperaturas.Min(t => t.Grados);
        }

        public double GetPromedio()
        {
            return Temperaturas.Average(t => t.Grados);
        }

        public Celsius GetTemperatura( int iIndice)
        {
            return Temperaturas[iIndice];
        }

        public void ModificarGrados( double nuevaTemperatura,  int iIndice)
        {
            Temperaturas[iIndice].Grados=nuevaTemperatura;
        }
    }
}
