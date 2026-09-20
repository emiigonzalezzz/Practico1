using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;

namespace Practico1
{
    public class Practico1
    {
        public static void Ejercicio1()
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El numero ingresado es: " + numero);
        }
        public static void Ejercicio2()
        {
            Console.Write("Ingrese el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;
            Console.WriteLine("La suma es: " + suma);
        }
        public static void Ejercicio3()
        {
            Console.Write("Ingrese el primer numero: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int multiplicacion = numero1 * numero2;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La resta es: " + resta);
            Console.WriteLine("La multiplicacion es " + multiplicacion);
        }
        public static void Ejercicio4()
        {
            Console.Write("Ingrese la base del rectangulo: ");
            double base1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectangulo: ");
            double altura = double.Parse(Console.ReadLine());

            double area = base1 * altura;
            Console.WriteLine("El area es: " + area);
        }
        public static void Ejercicio5()
        {
            Console.Write("Ingrese la base del  rectangulo: ");
            double base1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del rectangulo: ");
            double altura = double.Parse(Console.ReadLine());

            double perimetro = 2 * (base1 + altura);
            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);

        }
        public static void Ejercicio6()
        {
            Console.Write("Ingrese la temperatura en celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5 + 32);
            Console.WriteLine("La temperatura en fahrenheit es: " + fahrenheit);
        }

        public static void Ejercicio7()
        {
            Console.Write("Ingrese los kilometros: ");
            double kilometros = double.Parse(Console.ReadLine());

            double metros = kilometros * 1000;
            Console.WriteLine("Los kilometros convertidos en metros son: " + metros);
        }
        public static void Ejercicio8()
        {
            Console.Write("Ingrese el primer numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer numero: ");
            double num3 = double.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine("El promedio es: " + promedio);
        }
        public static void Ejercicio9()
        {
            Console.Write("Ingrese un numero: ");
            double num = double.Parse(Console.ReadLine());

            double doble = num * 2;
            double triple = num * 3;
            Console.WriteLine("El doble del numero es: " + doble);
            Console.WriteLine("El triple del numero es: " + triple);
        }
        public static void Ejercicio10()
        {
            Console.Write("Ingrese un precio: ");
            double precio = double.Parse(Console.ReadLine());
            double iva = precio * 0.22;
            double preciofinal = precio + iva;
            Console.WriteLine("El precio con iva es: " + preciofinal);
        }

    }
}
