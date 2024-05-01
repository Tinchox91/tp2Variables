using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuVariables
{
    internal class Calculo
    {

        public double CalcularPromedio()
        {
            int edades = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese edad: ", i + 1);
                int edad = int.Parse(Console.ReadLine());
                edades += edad;
            }
            double prom = edades / 3.0;
            Console.WriteLine("El promedio de las 3 edades es: " + prom);
            Console.ReadLine();
            return prom;
        }
        public double CalcularArea()
        {
            double area = 0;
            Console.WriteLine("ingrese la base: ");
            double basee = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura: ");
            double altura = double.Parse(Console.ReadLine());
            area = basee * altura;
            Console.WriteLine("El area es : " + area);
            Console.ReadLine();
            return area;
        }
        public double CalcularDescuento()
        {
            double descuento = 0;
            Console.WriteLine("Ingrese el precio del producto y se hara un descuento del 40% !!!");
            double precio = double.Parse(Console.ReadLine());
            descuento = precio * 0.4;
            Console.WriteLine($"el precio final es: $  {descuento}");//se pone $ al principo y la variable entre {}
            Console.ReadLine();

            return descuento;
        }
        public int SumatoriaEdades()
        {
            int edad = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese edad : ", i + 1);
                int edad1 = int.Parse(Console.ReadLine());
                edad += edad1;
            }
            Console.WriteLine($"La suma de las edades es: {edad}");
            Console.ReadLine();
            return edad;
        }
        public double ConvertirGrados()
        {
            double celsius;
            Console.WriteLine("Ingrese grados Celsius: ");
            celsius = double.Parse(Console.ReadLine());
            double total = (celsius * 9 / 5) + 32;
            Console.WriteLine(celsius + "º en grados Fahrenheint es: " + total + "f");
            Console.ReadLine();
            return total;
        }
        public double CalcularAltura()
        {
            Console.WriteLine("ingrese altura en metros");
            double altura1 = double.Parse(Console.ReadLine());
            double total = altura1 * 2.54;
            Console.WriteLine("La altura {0} metros en pulgadas es {1}", altura1, total);//se ingresa la coordenada en orden de la variable 
            Console.ReadLine();
            return total;
        }
        public double CaluclarImc()
        {
            Console.WriteLine("Ingrese su peso en kg:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en metros:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Su IMC es: " + imc);
            Console.ReadLine();
            return imc;


        }
        public int CaluclarMascota()
        {
            Console.WriteLine("Ingrese edad de la mascota: ");
            int edad = int.Parse(Console.ReadLine());
            edad = edad * 7;
            Console.WriteLine("La edad en años humanos de tu mascota es: " + edad);
            Console.ReadLine();
            return edad;
        }
        public double CalcularViaje()
        {
            Console.WriteLine("ingrese la distancia en km: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la velocidad en km por hora: ");
            double velocidad = double.Parse(Console.ReadLine());
            double total = km / velocidad;
            Console.WriteLine("el tiempo de viaje es de " + total + " hs");
            Console.ReadLine();


            return total;
        }
        public double CalcularDuracion()
        {
            Console.WriteLine("ingrese la cantidad de minutos de duracion de la pelicula: ");
            double duracion = double.Parse(Console.ReadLine());
            double hs = Math.Round(duracion / 60);
            double minutos = duracion % 60;


            Console.WriteLine("la duracion seria " + hs + " horas " + minutos + " minutos");
            Console.ReadLine();
            return hs;
        }
        public float CalularCosto()
        {

            Console.WriteLine("ingrese el costo de cena");
            float cena = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el costo del cine");
            float cine = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el costo del transporte");
            float transporte = float.Parse(Console.ReadLine());
            float total = cena + cine + transporte;
            Console.WriteLine("El total de la salida es: $ " + total);
            Console.ReadLine();


            return total;

        }
        public float CalcularPromedio2()
        {
            int edades = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la nota " + (i + 1) + " :");
                int edad = int.Parse(Console.ReadLine());
                edades += edad;
            }
            float prom = edades / 3;
            Console.WriteLine("El promedio de las 3 notas es: " + prom);
            Console.ReadLine();
            return prom;
        }
        public float CalularPerimetro()
        {
            float perimetro = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el lado " + (i + 1) + " :");
                float lado = float.Parse(Console.ReadLine());
                perimetro += lado;
            }

            Console.WriteLine("El perimetro del triangulo es: " + perimetro);
            Console.ReadLine();
            return perimetro;
        }
        public float CalcularCambio()
        {
            float total = 0.0f;
            Console.WriteLine("ingrese monto a cambiar:");
            float monto = float.Parse(Console.ReadLine());
            Console.WriteLine("indica el numero segun el tipo de dolar que desea cambiar: ");
            Console.WriteLine("1_Dolar blue: $ 1.015 ");
            Console.WriteLine("2_Dolar MEP: $ 1.026,47");
            Console.WriteLine("3_Dolar Oficial: $ 890");
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    {
                        total = monto * 1015;
                        Console.WriteLine("el total en pesos de " + monto + " es: $ " + total);
                        Console.ReadLine();
                        break;
                    }
                case "2":
                    {
                        total = monto * 1026.47f;
                        Console.WriteLine("el total en pesos de " + monto + " es: $ " + total);
                        Console.ReadLine();
                        break;
                    }
                case "3":
                    {
                        total = monto * 890;
                        Console.WriteLine("el total en pesos de " + monto + " es: $ " + total);
                        Console.ReadLine();
                        break;
                    }

            }

            return total;
        }
        public void CalcularAreaCirculo()
        {
            Console.WriteLine("ingrese el radio: ");
            float radio = float.Parse(Console.ReadLine());
            float area = 3.14f * (radio * radio);
            Console.WriteLine("El area es: " + area);
            Console.ReadLine();

        }


    }
}

