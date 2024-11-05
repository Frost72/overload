using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_лаба_6_Перегрузка
{
    public class Array 
    {
        public int[] ar1;
        public char[] ar2;
        public Array(int[] size) 
        {
            ar1 =  size;
        }
        public Array(char[] size) 
        {
            ar2 = size;
        }
        public static Array operator ! (Array a) 
        {
            if (a.ar1 != null)
            {
                int[] newar1 = new int[a.ar1.Length];
                for (int i = 0; i < a.ar1.Length; i++)
                {
                    newar1[i] = a.ar1[a.ar1.Length - 1 - i];
                }
                return new Array(newar1);
            }
            else
            {
                char[] newar2 = new char[a.ar2.Length];
                for (int i = 0; i < a.ar2.Length; i++)
                {
                    newar2[i] = a.ar2[a.ar2.Length-1-i];
                }
                return new Array(newar2);
            }
        }
       
        
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            Array array1 = new Array(arr1);

            Array result = !array1; // Использование перегруженного оператора '!'

            Console.WriteLine("Результат: ");
            foreach (int element in result.ar1)
            {
                Console.Write(element + " ");
            }
            char[] arr2 = new char[] { 'q','w','e','r','t' };
            Array array2 = new Array(arr2);

            Array result2 = !array2; // Использование перегруженного оператора '!' для массива строк

            Console.WriteLine("\nРезультат для массива строк: ");
            foreach (char element in result2.ar2)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
