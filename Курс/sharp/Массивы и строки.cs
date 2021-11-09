using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] diagonal = { {1,0,0,0 },{ 0,2,0,0},{0,0,3,0 },{0,0,0,4 } };
            for (int i = 0; i < 4; i++)
            { 
                Console.WriteLine(diagonal[i,i]);
            }

            object[,] spisok = new string[5, 2];
            for (int i = 0; i<5;i++)
            {
                for(int j =0; j<2;j++)
                {
                    if (j == 0)
                    { 
                        Console.WriteLine("Введите имя");
                        string name = Console.ReadLine();
                        spisok[i, j] = name;
                    }
                    else
                    { 
                        Console.WriteLine("Введите номер телефона/email");
                        string email = Console.ReadLine();
                        spisok[i, j] = email;
                    }
                }
            }
            
            for(int i =0; i<5;i++)
            {
                Console.WriteLine("\n" + spisok[i, 0]);
                Console.WriteLine(spisok[i, 1]);
            }

            Console.WriteLine("\nВведите слово");
            Console.WriteLine(new string(Console.ReadLine().ToCharArray().Reverse().ToArray()));

        }
    }
}
