using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Algoritmo_de_Busqueda
{
    internal class Program
    {
        public static Stopwatch stopwatch = new Stopwatch();
        public static Algoritmo algoritmo = new Algoritmo();


        static void Main(string[] args)
        {
            algoritmo.GenerateRandomNumlist();
            stopwatch.Start();
            algoritmo.FindRandomNumFirst();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.ToString());
            stopwatch.Reset();

        }

        /*Resultados de FindRandomNumFirst algoritmo, este algoritmo recorre la lista compradando cada elemento hasta encontrar el indicado
         * se estara haciendo la prueba con una lista de 10000 numeros aleatorios
         * 1.Se encontró el valor 1269 en la iteración 9552 y el tiempo fue de 00:00:00.0006855
         * 2.Se encontró el valor 4229 en la iteración 750 y el tiempo fue de 00:00:00.0005589
         * 3.Se encontró el valor 520 en la iteración 5056 y el tiempo fue de 00:00:00.0005834
         * 4.Se encontró el valor 1906 en la iteración 6766 y el tiempo fue de 00:00:00.0005701
         * 5.Se encontró el valor 7270 en la iteración 5025 y el tiempo fue de 00:00:00.0005254
         * 6.Se encontró el valor 7539 en la iteración 8175 y el tiempo fue de 00:00:00.0005451
         * 7.Se encontró el valor 1382 en la iteración 41 y el tiempo fue de 00:00:00.0005661
         * 8.Se encontró el valor 9666 en la iteración 4157 y el tiempo fue de 00:00:00.0005709
         * 9.Se encontró el valor 2358 en la iteración 3579 y el tiempo fue de 00:00:00.0006209
         * 10.Se encontró el valor 9936 en la iteración 4769 y el tiempo fue de 00:00:00.0005777
         * 
         * 
         * Mejor de los casos: El mejor de los casos fue la corrida 7 en la cualse hicieron un total de 41 iteraciones
         * 
         * De las iteraciones obtenidas obtenidos el promedio es de: 4787
         * 
         * El peor de los casos fur el primer caso el cual tuvo un total de 9552 iteraciones.
        */



    }
}
