using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            int[] array = new int[num];
            Random rand = new Random();
            for (int i = 0; i < num; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.WriteLine(array[i]);
            }
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            int indexMin = Array.FindIndex(array, x => x == min);
            int lastIndexMin = Array.FindLastIndex(array, x => x == min);
            Console.WriteLine("minimum");
            Console.WriteLine(min);
            Console.WriteLine("номер первого минимального =");
            Console.WriteLine(indexMin);
            Console.WriteLine("номер последнего минимального =");
            Console.WriteLine(lastIndexMin);
            Console.ReadLine();
        }
    }
}