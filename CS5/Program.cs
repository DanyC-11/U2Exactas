using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesion 12: Instruccion while 30092026
            // Sintaxis: while
            // Inicializacion;
            // while(expresion)
            // {
            //  Bloque de instrucciones
            //  Iterador;
            // }
            // Iterar: repetir

            // Ejemplo 1: Ciclo ascendente (rango 1-3)
            // a. Ciclo ascendente
            // m: variable de control
            int m = 1; // Inicializacion
            while(m <= 3) // Expresion
            {
                // Bloque de instrucciones
                m += 1; // Iterador
                Console.WriteLine($"m: {m}");
                
            }
            // Ejercitacion
            // 1. Definir un ciclo para imprimir tu nombre.
            // Nota: Para la expresion, utilizar el operador <
            int rep = 0;
            while (rep < 5)
            {
                Console.WriteLine("Daniela Cordova 331-07");
                rep += 1;
            }
            // b. Ciclo descendente
            int d = 3;
            while(d>= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }
            // c. Incrementos
            // Secuencia: 3 6 9 12 15 18
            int i = 3;
            while(i <= 18)
            {
                Console.WriteLine($"i: {i}");
                i += 3;
            }
            // d. Decrementos
            // Ejercitacion:
            // Definir un ciclo para imprimir "331" 8 veces
            // Nota: Para la solucion, definir un ciclo descendente con decremento de 2 unidades.
            int s = 16;
            while(s > 0)
            {
                Console.WriteLine("331");
                s -= 2;
            }
            // Actividad 1: Ciclo infinito
            // 1. Definir un ciclo infinito ascendente.
            // 2. Definir un ciclo infinito descendente.
            // Nota: para la solucion, utilizar el operador de diferencia.

            // 1. Infinito ascendente
            int x = 0;
            while(x >= 0)
            {
                x += 1;
            }

            // 2. Infinito descendente
            int y = 0;
            while(y != 1)
            {
                y -= 1;
            }

        }

    }
}   

