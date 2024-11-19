using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
                    Console.WriteLine("Menu");
                    Console.WriteLine("---------------------------------");
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
                    Console.Clear();
                    if (answer == 0)
                    {
                        exit = 0;
                        break;
                    }
                    switch (answer)
                    {
                        case 1:
                            Question1();
                            break;
                        case 2:
                            Question2();
                            break;
                        case 3:
                            Question3();
                            break;
                        case 4:
                            Question4();
                            break;
                        case 5:
                            Question5();
                            break;
                        case 6:
                            Question6();
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                    answer = -1;
                }
                
            }
        }

        //Questions
        static void Question1()
        {
            Console.Clear();
            int[] numbers = FillArrayInt10();
            int[] numbersMultiplied = ArrayMultiplier(numbers);
            Console.Clear();
            PrintArray(numbersMultiplied);
            Console.ReadKey();
            Console.Clear();
            
        }
        static void Question2()
        {
            int[] numbers = FillArrayInt5();
            int[] numbersReverse = ReverseArray(numbers);
            Console.Clear();
            PrintArray(numbersReverse);
            Console.ReadKey();
            Console.Clear();
        }

        static void Question3()
        {
            int[,] matrixA = FillMatrix4X4();
            int[,] matrixB = FillMatrix4X4();
            int[,] sum = SumMatrix4X4(matrixA, matrixB);
            PrintMatrix4X4(sum);
            Console.ReadKey();
            Console.Clear();
        }
        static void Question4()
        {
            double[,] matrix = new double[12, 4];
            for (int l = 0; l < 12; l++)
            {
                string month = "";
                switch (l)
                {
                    case 0:
                        month = "January";
                        break;
                    case 1:
                        month = "February";
                        break;
                    case 2:
                        month = "March";
                        break;
                    case 3:
                        month = "April";
                        break;
                    case 4:
                        month = "May";
                        break;
                    case 5:
                        month = "June";
                        break;
                    case 6:
                        month = "July";
                        break;
                    case 7:
                        month = "August";
                        break;
                    case 8:
                        month = "September";
                        break;
                    case 9:
                        month = "October";
                        break;
                    case 10:
                        month = "November";
                        break;
                    case 11:
                        month = "December";
                        break;
                }
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Value of the selling on week {c + 1} of {month}: ");
                    matrix[l, c] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.Clear();

            double sumMonth = 0.0;
            for (int l = 0; l < 12; l++)
            {
                string month = "";
                switch (l)
                {
                    case 0:
                        month = "January";
                        break;
                    case 1:
                        month = "February";
                        break;
                    case 2:
                        month = "March";
                        break;
                    case 3:
                        month = "April";
                        break;
                    case 4:
                        month = "May";
                        break;
                    case 5:
                        month = "June";
                        break;
                    case 6:
                        month = "July";
                        break;
                    case 7:
                        month = "August";
                        break;
                    case 8:
                        month = "September";
                        break;
                    case 9:
                        month = "October";
                        break;
                    case 10:
                        month = "November";
                        break;
                    case 11:
                        month = "December";
                        break;
                }
                for (int c = 0; c < 4; c++)
                {
                    sumMonth += matrix[l, c];
                }
                Console.Write($"Total({month}): {sumMonth}\n");
                sumMonth = 0.0;
            }
            Console.Write("-------------------------------------------\n");
            double sumWeek = 0.0;
            for (int c = 0; c < 4; c++)
            {
                for (int l = 0; l < 12; l++)
                {
                    sumWeek += matrix[l,c];
                }
                Console.WriteLine($"Total Week({c}): {sumWeek}");
                sumWeek = 0;
            }
            Console.Write("-------------------------------------------\n");
            double totalYear = 0.0;
            for (int l = 0; l < 12; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    totalYear += matrix[l, c];
                }
            }
            Console.WriteLine($"Total Year: {totalYear}");
            Console.ReadKey();
            Console.Clear();
        }
        static void Question5()
        {
            List<string> listColor = new List<string>();
            listColor.Add("Branco");
            listColor.Add("Vermelho");
            listColor.Add("Amarelo");
            listColor.Add("Azul");
            listColor.Add("Rosa");

            PrintList(listColor);
            Console.ReadKey();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                string firstItem = listColor[0];
                listColor.RemoveAt(0);
                listColor.Add(firstItem);
            }

            PrintList(listColor);
            
            Console.ReadKey();
            Console.Clear();
        }

        static void Question6()
        {
            List<string> Users = new List<string>();
            int option = -1;
            while(option != 0)
            {
                option = MenuFunctionList();
                switch (option)
                {
                    case 1:
                        AddUser(Users);
                        break;
                    case 2:
                        RemoveUser(Users);
                        break;
                    case 3:
                        ReplaceUser(Users);
                        break;
                    case 4:
                        ClearList(Users);
                        break;
                    case 5:
                        PrintList(Users);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            
           
            
            
        }
        //Functions
        //-----------------------------------------------
        static int[] FillArrayInt10()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Fill the array with int numbers: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static int[] FillArrayInt5()
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Fill the array with int numbers: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static int[] ArrayMultiplier(int[]array)
        {
            int[] arrayMultiplied = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    arrayMultiplied[i] = array[i] * array[i + 1];
                }
                else
                {
                    arrayMultiplied[i] = array[i] * 1;
                }
            }
            return arrayMultiplied;
        }

        static int[] ReverseArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverseArray[array.Length - i - 1] = array[i];
            }
            return reverseArray;
        }

        static int[,] FillMatrix4X4()
        {
            int[,] matrix4x4 = new int[4, 4];
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Type and int value for[{l},{c}]: ");
                    matrix4x4[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            return matrix4x4;
        }

        static int[,] SumMatrix4X4(int[,] matrixA, int[,] matrixB)
        {
            int[,] sum = new int[4, 4];
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    sum[l,c] = matrixA[l,c] + matrixB[l,c];
                }
            }
            return sum;
        }
        static int MenuFunctionList()
        {
            int answer = -1;
            while (answer < 0 || answer > 5)
            {
                Console.WriteLine("1 - Add user");
                Console.WriteLine("2 - Remove user");
                Console.WriteLine("3 - Replace user");
                Console.WriteLine("4 - Clear the list");
                Console.WriteLine("5 - Show the list");

                Console.Write("Select an option: ");
                answer = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            return answer;
        }


        //-----------------------------------------------

        //Procedures
        //-----------------------------------------------
        static void PrintArray(int[]array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write($"{array[i]}|");
                }
                else
                {
                    Console.Write(array[i]);
                }
            }
        }
        static void PrintMatrix4X4(int[,] matrix)
        {
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"{matrix[l, c]}\t");
                }
                Console.WriteLine();
            }
        }
       
        static void PrintList(List<string> list)
        {
            foreach (string e in list)
            {
                Console.WriteLine(e);
            }
        }
        static void AddUser(List<string> list)
        {
            string user = "";
            bool end = false;
            while (end != true)
            {
                Console.Write("Type an user to add to the list (0 = exit): ");
                user = Console.ReadLine();

                if (user == "0")
                {
                    end = true;
                    Console.Clear();
                    break;
                }
                else
                {
                    if (list.Contains(user))
                    {
                        Console.WriteLine("This user already exists!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        list.Add(user);
                        Console.Clear();
                    }
                }

            }

        }
        static void RemoveUser(List<string> list)
        {
            string end = "-1";
            while (end != "0")
            {
                string user = "";
                Console.Write("Type an user to remove from the list (0 = exit): ");
                user = Console.ReadLine();
                if (list.Contains(user))
                {
                    list.Remove(user);
                    Console.Clear();
                }
                else if(user == "0")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("This user does not exist");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
        static void ReplaceUser(List<string> list)
        {
            string end = "-1";
            while (end != "0")
            {
                Console.Write("What object of the list do you want to replace(0 = exit):");
                string answer = Console.ReadLine();
                Console.Clear();
                if (list.Contains(answer)) 
                {
                    int index = list.IndexOf(answer);
                    Console.Write("Type what you want to replace it for: ");
                    list[index] = Console.ReadLine();
                    Console.Clear();
                }
                else if (answer == "0")
                {
                    end = "0";
                    break;
                }
                else
                {
                    Console.WriteLine("This element doesn't exist!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void ClearList(List<string> list)
        {
            Console.Clear();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                list.RemoveAt(i);
            }
            Console.WriteLine("List cleaned!");
            Console.ReadKey();
            Console.Clear();

        }
    }
    
}
