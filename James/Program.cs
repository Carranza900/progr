﻿using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int opcion = 0;
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.WriteLine("menú de operaciones:");
            Console.WriteLine("1. Pares e Impares");
            Console.WriteLine("2. Tabla de multiplicar");
            Console.WriteLine("3. Factorial de un número");
            Console.WriteLine("4. Números Primos");
            Console.WriteLine("5. Sucesión de Fibonacci");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción del 1 al 6: ");

            string? input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        ParesImpares();
                        break;
                    case 2:
                        TablaDeMultiplicar();
                        break;
                    case 3:
                        Factorial();
                        break;
                    case 4:
                        NumerosPrimos();
                        break;
                    case 5:
                        Fibonacci();
                        break;
                    case 6:
                        Console.WriteLine("¡Adios...!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. ingrese un número del 1 al 6.");
            }

        } while (opcion != 6); // Continuar hasta que se seleccione la opción 6 (Salir)
    }
    // Implementación de las funciones:
        static void ParesImpares()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo para realizar las operaciones de pares e impares: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                Console.WriteLine("Pares: ");
                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Impares: ");
                for (int i = 0; i <= numero; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine();

                int sumaPares = Enumerable.Range(0, numero + 1).Where(x => x % 2 == 0).Sum();
                int sumaImpares = Enumerable.Range(0, numero + 1).Where(x => x % 2 != 0).Sum();
                Console.WriteLine($"Suma de pares: {sumaPares}");
                Console.WriteLine($"Suma de impares: {sumaImpares}");
                Console.WriteLine(sumaPares > sumaImpares ? "La suma de pares es mayor que la suma de impares." : "La suma de impares es mayor que la suma de pares.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea realizar otra operación en Pares e Impares? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
       static void TablaDeMultiplicar()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo para mostrar su tabla de multiplicar: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{numero}x{i} = {numero * i}");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea realizar otra operación en Tabla de Multiplicar? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
    }
        static void Factorial()
    {
        do
        {
            Console.Clear(); // Limpiar la pantalla
            Console.Write("Ingrese un número entero positivo para calcular y mostrar el factorial de ese numero: ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"El factorial de {numero} es {factorial}");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
            }

            Console.Write("¿Desea calcular otro factorial? (s/n): ");
        } while (Console.ReadLine()?.Trim().ToLower() == "s");

        Console.Clear(); // Limpiar la pantalla antes de salir de la función
