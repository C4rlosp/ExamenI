using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI
{
    public class ClsTransacciones
    {
        private int[] numeros = new int[15];
        private string[] cadenas = new string[15];
        private int[] numfactura = new int[15];
        private string[] numPlaca = new string[15];
        private int[] tipoVehiculo = new int[15];
        private int[] numCaseta = new int[15];
        private int[] montoPagar = new int[15];
        private int[] pagaCon = new int[15];

        public void InicializarVectores()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 0;
                cadenas[i] = "";
                numfactura[i] = 0;
                numPlaca[i] = "";
                tipoVehiculo[i] = 0;
                numCaseta[i] = 0;
                montoPagar[i] = 0;
                pagaCon[i] = 0;
            }
        }

    public void IngresarPasoVehicular()
        {
            bool seguirAgregando = true;
            int i = 0;

            while (seguirAgregando && i < numeros.Length && i < cadenas.Length)
            {
                Console.WriteLine("Ingrese los datos de la transacción:");

                Console.Write("Número de factura: ");
                numeros[i] = int.Parse(Console.ReadLine());

                Console.Write("Número de placa: ");
                cadenas[i] = Console.ReadLine();

                Console.Write("Fecha: ");
                cadenas[i + 1] = Console.ReadLine();

                Console.Write("Hora: ");
                cadenas[i + 2] = Console.ReadLine();

                Console.Write("Tipo de vehículo (1= Moto ,2= Vehículo Liviano, 3 =Camión o Pesado, 4=Autobús): ");
                int tipoVehiculo = int.Parse(Console.ReadLine());
                numeros[i + 1] = tipoVehiculo;

                Console.Write("Número de caseta (1,2,3): ");
                int numeroCaseta = int.Parse(Console.ReadLine());
                numeros[i + 2] = numeroCaseta;

                int montoAPagar = 0;
                switch (tipoVehiculo)
                {
                    case 1:
                        montoAPagar = 500;
                        break;
                    case 2:
                        montoAPagar = 700;
                        break;
                    case 3:
                        montoAPagar = 2700;
                        break;
                    case 4:
                        montoAPagar = 3700;
                        break;
                    default:
                        Console.WriteLine("Tipo de vehículo inválido.");
                        break;
                }

                if (montoAPagar != 0)
                {
                    Console.Write("Monto a pagar: ");
                    int montoPagado = int.Parse(Console.ReadLine());

                    if (montoPagado >= montoAPagar)
                    {
                        int devolucion = montoPagado - montoAPagar;
                        Console.WriteLine("Su devolución es de {0} colones.", devolucion);
                    }
                    else
                    {
                        Console.WriteLine("Monto insuficiente. Debe pagar al menos {0} colones.", montoAPagar);
                    }
                }

                i += 3;

                Console.WriteLine("¿Desea agregar otra transacción? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "n")
                {
                    seguirAgregando = false;
                }
            }
        }
        public void ConsultaVehiculoPorPlaca()
        {

            Console.Write("Ingrese el número de placa a consultar: ");
            string placa = Console.ReadLine();
            bool encontrado = !false;


            for (int i = 0; i < numeros.Length; i++)
            {
                if (cadenas[i] == placa)
                {
                    encontrado = true;

                    Console.WriteLine("Número de factura: {0}", numeros[i]);
                    Console.WriteLine("Número de placa: {0}", cadenas[i]);
                    Console.WriteLine("Fecha: {0}", cadenas[i + 1]);
                    Console.WriteLine("Hora: {0}", cadenas[i + 2]);
                    Console.WriteLine("Número de caseta: {0}", numCaseta[i]);
                    Console.WriteLine("Monto a pagar: {0}", montoPagar[i]);
                    Console.WriteLine("Monto pagado: {0}", pagaCon[i]);
                    Console.WriteLine("Vuelto: {0}", pagaCon[i] - montoPagar[i]);

                    int tipoVehiculo = numeros[i + 1];
                    string descripcionTipoVehiculo = "";
                    switch (tipoVehiculo)
                    {
                        case 1:
                            descripcionTipoVehiculo = "Moto";
                            break;
                        case 2:
                            descripcionTipoVehiculo = "Vehículo Liviano";
                            break;
                        case 3:
                            descripcionTipoVehiculo = "Camión o Pesado";
                            break;
                        case 4:
                            descripcionTipoVehiculo = "Autobús";
                            break;
                    }
                    Console.WriteLine("Tipo de vehículo: {0}", descripcionTipoVehiculo);

                    Console.WriteLine("Número de caseta: {0}", numeros[i + 2]);

                    int montoAPagar = 0;
                    switch (tipoVehiculo)
                    {
                        case 1:
                            montoAPagar = 500;
                            break;
                        case 2:
                            montoAPagar = 700;
                            break;
                        case 3:
                            montoAPagar = 2700;
                            break;
                        case 4:
                            montoAPagar = 3700;
                            break;
                    }

                    Console.WriteLine("Monto a pagar: {0} colones", montoAPagar);
                    Console.WriteLine("----------------------------------------");
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ninguna transacción con esa placa.");
                return;
            }
        }

         

        public void ModificarDatosVehiculoPorPlaca()
        {
            Console.Write("Ingrese el número de placa a modificar: ");
            string placa = Console.ReadLine();

            bool encontrado = false;
            int indice = -1;
            for (int i = 0; i < cadenas.Length; i++)
            {
                if (cadenas[i] == placa)
                {
                    encontrado = true;
                    indice = i;
                    Console.WriteLine("Datos de la transacción:");
                    Console.WriteLine("Número de factura: {0}", numeros[i]);
                    Console.WriteLine("Número de placa: {0}", cadenas[i]);
                    Console.WriteLine("Fecha: {0}", cadenas[i + 1]);
                    Console.WriteLine("Hora: {0}", cadenas[i + 2]);

                    int tipoVehiculo = numeros[i + 1];
                    string descripcionTipoVehiculo = "";
                    switch (tipoVehiculo)
                    {
                        case 1:
                            descripcionTipoVehiculo = "Moto";
                            break;
                        case 2:
                            descripcionTipoVehiculo = "Vehículo Liviano";
                            break;
                        case 3:
                            descripcionTipoVehiculo = "Camión o Pesado";
                            break;
                        case 4:
                            descripcionTipoVehiculo = "Autobús";
                            break;
                    }
                    Console.WriteLine("Tipo de vehículo: {0}", descripcionTipoVehiculo);

                    Console.WriteLine("Número de caseta: {0}", numeros[i + 2]);

                    int montoAPagar = 0;
                    switch (tipoVehiculo)
                    {
                        case 1:
                            montoAPagar = 500;
                            break;
                        case 2:
                            montoAPagar = 700;
                            break;
                        case 3:
                            montoAPagar = 2700;
                            break;
                        case 4:
                            montoAPagar = 3700;
                            break;
                    }

                    Console.WriteLine("Monto a pagar: {0} colones", montoAPagar);
                    Console.WriteLine("----------------------------------------");
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ninguna transacción con esa placa.");
                return;
            }

            Console.WriteLine("Seleccione el dato a modificar:");
            Console.WriteLine("1. Monto a pagar");

            int opcion = -1;
            while (opcion < 1 || opcion > 1)
            {
                Console.Write("Ingrese una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = -1;
                }
            }

            switch (opcion)
            {
                case 1:
                    int montoNuevo = -1;
                    while (montoNuevo < 0)
                    {
                        Console.Write("Ingrese el nuevo monto a pagar: ");
                        if (!int.TryParse(Console.ReadLine(), out montoNuevo))
                        {
                            montoNuevo = -1;
                        }
                    }
                    numeros[indice + 3] = montoNuevo;
                    Console.WriteLine("El monto a pagar ha sido actualizado correctamente.");
                    break;
            }
        }
        public void Reporte()
        {
            Console.WriteLine("Transacciones ingresadas:");
            Console.WriteLine("Número de factura\tNúmero de placa\tFecha\t\tHora\t\tTipo de vehículo\tNúmero de caseta\tMonto a pagar\tPaga con");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            int cantidadVehiculos = 0;
            int total = 0;

            for (int i = 0; i < numeros.Length; i += 3)
            {
                if (numeros[i] != 0 && !string.IsNullOrEmpty(cadenas[i]) && !string.IsNullOrEmpty(cadenas[i + 1]) && !string.IsNullOrEmpty(cadenas[i + 2]) && numeros[i + 1] != 0 && numeros[i + 2] != 0)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}\t{4}\t\t\t{5}\t\t{6}\t\t{7}", numeros[i], cadenas[i], cadenas[i + 1], cadenas[i + 2], numeros[i + 1], numeros[i + 2], ObtenerMontoAPagar(numeros[i + 1]), pagaCon[i]);
                    cantidadVehiculos++;
                    total += ObtenerMontoAPagar(numeros[i + 1]);
                }
            }

            Console.WriteLine("Cantidad de vehículos: {0} total: {1}", cantidadVehiculos, total);
            Console.WriteLine("\n<<< Pulse tecla para regresar >>>");
            Console.ReadKey();
        }

        private int ObtenerMontoAPagar(int tipoVehiculo)
        {
            int montoAPagar = 0;
            switch (tipoVehiculo)
            {
                case 1:
                    montoAPagar = 500;
                    break;
                case 2:
                    montoAPagar = 700;
                    break;
                case 3:
                    montoAPagar = 2700;
                    break;
                case 4:
                    montoAPagar = 3700;
                    break;
                default:
                    Console.WriteLine("Tipo de vehículo inválido.");
                    break;
            }
            return montoAPagar;
        }

    }

}
