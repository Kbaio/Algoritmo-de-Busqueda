using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Algoritmo_de_Busqueda
{
    internal class Program
    {
        public static Stopwatch stopwatch = new Stopwatch();
        public static List<int> randNumList = new List<int>();
        public static Random random = new Random();



        static void Main(string[] args)
        {

            stopwatch.Start();
            RandomNumlist(40);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.ToString());

            foreach(int number in randNumList)
            {
                Console.Write(number + ", ");
            }

        }
        public static void RandomNumlist(int MaxNums)
        {
            for (int i = 0; i < MaxNums; i++)
            {
                int RandomNum;
                do RandomNum = random.Next(0,1000);
                while (randNumList.Contains(RandomNum));
                randNumList.Add(RandomNum);
            }
        }
    }
}
