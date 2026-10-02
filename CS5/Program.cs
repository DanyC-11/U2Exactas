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
            //{
            //  Bloque de instrucciones
            //  Iterador;
            //}
            // Iterar: repetir
            // Ejemplo 1: Ciclo ascendente (rango 1-3)
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
                m += 1;
            }
        }

    }
}   

