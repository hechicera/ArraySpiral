using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv.spiral
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter length of the side: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[,] arr2 = new int[num, num];
           
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    arr2[i, j] = 0;                    
                }                
            }
            Console.WriteLine();

            int count = 1;
            int a = 0;            

            while (arr2[a, a] == 0)
            {
                if (arr2[a, a] == 0)
                {                    
                    for (int i = a; i <= a; i++) 
                    {
                        for (int j = a; j < num - a; j++) 
                        {
                            arr2[i, j] = count;
                            count++;
                        }
                    }
                   
                    for (int i = 1 + a; i < num - a; i++) 
                    {
                        for (int j = (num - 1) - a; j == (num - 1) - a; j++)
                        {
                            arr2[i, j] = count;
                            count++;
                        }
                    }
                    
                    for (int i = (num - 1) - a; i == (num - 1) - a; i++)
                    {
                        for (int j = (num - 2) - a; j >= 0 + a; j--)
                        {
                            arr2[i, j] = count;
                            count++;
                        }
                    }
                    
                    for (int i = (num - 2) - a; i > 0 + a; i--)
                    {
                        for (int j = 0 + a; j == 0 + a; j++)
                        {
                            arr2[i, j] = count;
                            count++;
                        }
                    }
                    a++;                   
                }
            }

            for (int i = 0; i < num; i++) 
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(arr2[i, j] + "\t ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
