using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuVariables
{
    internal class Inicio
    {
        static void Main(string[] args)
        {
            Calculo prom = new Calculo();
            int op1;
            do
            {
                Console.WriteLine("ingrese numero correspondiente para cada caso: ");
                Console.WriteLine("1__Calcular promedio de edades ");
                Console.WriteLine("2__Area de un rectangulo ");
                Console.WriteLine("3__Descuento en tienda ");
                Console.WriteLine("4__Edades y sumatoria ");
                Console.WriteLine("5__Temperatura en grados Fahrenheint");
                Console.WriteLine("6__Altura en pulgadas ");
                Console.WriteLine("7__ Calculo de IMC");
                Console.WriteLine("8__ Edad de mascotas");
                Console.WriteLine("9__Tiempo de viaje ");
                Console.WriteLine("10__Duracion de una pelicula ");
                Console.WriteLine("11__Gastos de una pelicula ");
                Console.WriteLine("12__Promedio de 3 calificaciones ");
                Console.WriteLine("13__Perimetro de un triagulo ");
                Console.WriteLine("14__Cambio de Dolar a Pesos argentinos ");
                Console.WriteLine("15__ Area de un circulo");
                Console.WriteLine("16__SALIR");
                string op = Console.ReadLine();
                op1 = int.Parse(op);

                switch (op)
                {
                    case "1":
                        {

                            prom.CalcularPromedio();
                            break;
                        }


                    case "2":
                        {

                            prom.CalcularArea();
                            break;
                        }
                    case "3":
                        {
                            prom.CalcularDescuento();

                            break;
                        }
                    case "4":
                        {

                            prom.SumatoriaEdades();

                            break;
                        }
                    case "5":
                        {

                            prom.ConvertirGrados();
                            break;
                        }
                    case "6":
                        {

                            prom.CalcularAltura();
                            break;
                        }
                    case "7":
                        {

                            prom.CaluclarImc();
                            break;
                        }
                    case "8":
                        {

                            prom.CaluclarMascota();
                            break;
                        }

                    case "9":
                        {

                            prom.CalcularViaje();
                            break;
                        }

                    case "10":
                        {

                            prom.CalcularDuracion();
                            break;
                        }
                    case "11":
                        {

                            prom.CalularCosto();
                            break;
                        }
                    case "12":
                        {

                            prom.CalcularPromedio2();
                            break;
                        }
                    case "13":
                        {
                            prom.CalularPerimetro();
                            break;
                        }
                    case "14":
                        {

                            prom.CalcularCambio();
                            break;
                        }
                    case "15":
                        {

                            prom.CalcularAreaCirculo();
                            break;
                        }
                }
                Console.Clear();

            } while (op1 <= 15);

        }
    }
}
