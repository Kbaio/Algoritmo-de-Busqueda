using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_de_Busqueda
{
    internal class Algoritmo
    {
        public List<int> randNumList = new List<int>();
        public Random random = new Random();
        public int maxNums = 10000;
 

        /// <summary>
        /// Esta funcion se encarga de definir el numero a buscar y recorre la lista de numeros
        /// en busca del numero definido.
        /// </summary>
        public void FindRandomNumFirst()
        {
            int searchNum = random.Next(0, maxNums);
            foreach (int number in randNumList)
            {
                if (number == searchNum)
                {
                    Console.WriteLine("Se encontró el valor "+ searchNum +" en la iteración " + randNumList.IndexOf(number));
                    break;
                }
            }
        }
        /// ALgoritmo alterno
        public void FindRandomNumSecond()
        {
            int searchNum = random.Next(0, maxNums);
            int start = 0;
            int end = maxNums-1;
            for(int i = 0; i < maxNums/2;i++)
            {
                if (randNumList[start] == searchNum) {
                    Console.WriteLine("Se encontró el valor "+ searchNum +" en la iteración " + i + " en la posicion " + start);
                    break;
                }else if (randNumList[end] == searchNum)
                {
                    Console.WriteLine("Se encontró el valor " + searchNum + " en la iteración " + i + " en la posicion " + end);
                    break;
                }
                else
                {
                    start++;
                    end--;
                }
            }


        }

        /// <summary>
        /// Esta funcion se encarga de generar numeros random y los agrega a la lista randNumList, adicionalmente se 
        /// veriica que los numeros no se repitan.
        /// </summary>
        public void GenerateRandomNumlist()
        {
            for (int i = 0; i < maxNums; i++)
            {
                int RandomNum;
                do RandomNum = random.Next(0, maxNums);
                while (randNumList.Contains(RandomNum));
                randNumList.Add(RandomNum);
            }
        }

    }
}
