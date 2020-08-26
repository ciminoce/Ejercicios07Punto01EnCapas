using System;
using ConsoleTables;
using Ejercicio07Punto01EnCapas.BL;
using Ejercicio07Punto01EnCapas.DL;

namespace Ejercicio07Punto01EnCapas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioDeTemperaturas repositorio=new RepositorioDeTemperaturas();
            do
            {
                #region Menu Principal

                int intOpcion;
                Console.Clear();//Limpia la pantalla
                Console.WriteLine("Menú Principal");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Ingresar Datos");
                Console.WriteLine("2 - Modificar Datos x Indice");
                Console.WriteLine("3 - Modificar Datos x Contenido");
                Console.WriteLine("4 - Listar Datos");
                Console.WriteLine("5 - Estadísticas de Datos");
                Console.WriteLine("6 - Listado Estadístico");
                Console.WriteLine("7 - Ordenar Datos");
                Console.WriteLine("8 - Reiniciar");
                Console.WriteLine();
                do
                {
                    Console.Write("Ingrese una opción del menú:");
                    if (!int.TryParse(Console.ReadLine(), out intOpcion))
                    {
                        Console.WriteLine("Opción mal ingresada");
                    }
                    else
                    {
                        break;//me saca del ciclo
                    }

                } while (true);
                #endregion

                #region Opcion Elegida

                switch (intOpcion)
                {
                    case 0://Salir del Programa
                        Environment.Exit(0);
                        break;
                    case 2:
                        ModificarPorIndice(repositorio);
                        break;
                    case 4:
                        MostrarDatos(repositorio);
                        break;
                    case 5:
                        DatosEstadisticos(repositorio);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                #endregion

            } while (true);

        }

        private static void ModificarPorIndice(RepositorioDeTemperaturas repositorio)
        {
            Console.Clear();
            Console.WriteLine("Modificación de Datos por índice");
            Console.WriteLine();
            MostrarDatos(repositorio);
            Console.Write("Ingrese el elemento a modificar:");
            var iIndice = int.Parse(Console.ReadLine());
            Console.WriteLine($"En la posición {iIndice} tiene {repositorio.GetTemperatura(iIndice).Grados}");
            Console.Write("Ingrese el valor del nuevo elemento:");
            var nuevaTemperatura = double.Parse(Console.ReadLine());
            repositorio.ModificarGrados(nuevaTemperatura, iIndice);

        }

        private static void DatosEstadisticos(RepositorioDeTemperaturas repositorio)
        {
            Console.Clear();
            Console.WriteLine("listado de datos");
            Console.WriteLine();
            var tabla=new ConsoleTable("Dato","Resultado");
            tabla.AddRow("Mayor Temperatura", repositorio.GetMayorTemperatura());
            tabla.AddRow("Menor Temperatura", repositorio.GetMenorTemperatura());
            tabla.AddRow("Promedio", repositorio.GetPromedio());
            tabla.Write(Format.Alternative);
            Console.ReadLine();
        }

        private static void MostrarDatos(RepositorioDeTemperaturas repositorio)
        {
            Console.Clear();
            Console.WriteLine("listado de datos");
            Console.WriteLine();
            var iCantidad = repositorio.GetCantidad();//la cantidad se la pido al repositorio
            var lista = repositorio.GetLista();//le pido la lista al repositorio
            
            // Armo la vista de la tabla
            var tabla = new ConsoleTable("Celsius","Fahrenheit");
            foreach (var temperatura in lista)
            {
                tabla.AddRow(temperatura.Grados,temperatura.GetGradosFahrenheit());
            }

            tabla.AddRow("Cantidad:", iCantidad);
            tabla.Write(Format.Alternative);
            Console.ReadLine();
        }
    }
}
