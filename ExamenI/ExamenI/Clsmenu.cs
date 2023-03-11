using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI
{
    public class ClsMenu
    {
        private ClsTransacciones transacciones = new ClsTransacciones();

        public void MostrarMenu()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Menú Principal del Sistema");
                Console.WriteLine("1. Inicialice los Vectores");
                Console.WriteLine("2. Ingresar Paso Vehicular");
                Console.WriteLine("3. Consulta de vehículos x Número de Placa");
                Console.WriteLine("4. Modificar Datos Vehículos x número de Placa");
                Console.WriteLine("5. Reporte Todos los Datos de los vectores");
                Console.WriteLine("6. Salir");

                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        transacciones.InicializarVectores();
                        Console.WriteLine("\nVectores inicializados correctamente");
                        Console.ReadKey();
                        Console.WriteLine("\nPresione cualquier tecla para volver");
                        break;
                    case 2:
                        transacciones.IngresarPasoVehicular();
                        break;
                    case 3:
                        transacciones.ConsultaVehiculoPorPlaca();
                        break;
                    case 4:
                        transacciones.ModificarDatosVehiculoPorPlaca();
                        break;
                    case 5:
                        transacciones.Reporte();
                        break;
                    case 6:
                        Console.WriteLine("\nSaliendo del sistema...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida, intente de nuevo");
                        Console.ReadKey();
                        break;
                }

            } while (opcion != 6);
        }
    }

}
