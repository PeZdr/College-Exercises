using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int exit = -1;
            int answer = -1;
            while (exit != 0)
            {
                while (answer < 0 || answer > 10)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Menu");
                    Console.WriteLine("Select the question you want to see:");
                    Console.WriteLine("Question - 1");
                    Console.WriteLine("Question - 2");
                    Console.WriteLine("Question - 3");
                    Console.WriteLine("Question - 4");
                    Console.WriteLine("Question - 5");
                    Console.WriteLine("Question - 6");
                    Console.WriteLine("Question - 7");
                    Console.WriteLine("Question - 8");
                    Console.WriteLine("Question - 9");
                    Console.WriteLine("Question - 10");
                    Console.WriteLine("---------------------------------");
                    Console.Write("Type here(0 = exit): ");
                    answer = int.Parse(Console.ReadLine());
                    if (answer == 0)
                    {
                        exit = 0;
                        break;
                    }
                    switch (answer)
                    {
                        case 1:
                            Console.Clear();
                            Question1();
                            answer = -1;
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                }
                
            }
        }

        //Questions
        static void Question1()
        {
            Console.Clear();
            int[] numbers = new int[10];
            FillArrayInt(numbers);
            int[] numbersMultiplied = new int[10];
            PrintArrayMultiplier(numbers, numbersMultiplied);
            Console.ReadKey();
            Console.Clear();
            
        }
        
        static void FillArrayInt(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Fill the array with int numbers: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
        }
        static void PrintArrayMultiplier(int[]array1, int[]array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (i < array1.Length - 1)
                {
                    array2[i] = array1[i] * array1[i + 1];
                }
                else
                {
                    array2[i] = array1[i] * 1;
                }
            }
            for (int i = 0; i < array2.Length; i++)
            {
                if (i < array2.Length - 1)
                {
                    Console.Write($"{array2[i]}|");
                }
                else
                {
                    Console.Write(array2[i]);
                }
                
            }
        }
    }
}
