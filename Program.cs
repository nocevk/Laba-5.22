﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                int[] array = new int[30];
                Random random = new Random();

  
                for (int i = 0; i < array.Length; i++) { 
                
                    array[i] = random.Next(-10, 10);
                }

               
                Console.WriteLine("Початковий масив:");
                Console.WriteLine(string.Join(", ", array));

               
                int result = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[result])
                    {
                        result = i;
                    }
                }

                
                for (int i = result + 1; i < array.Length - 1; i++)
                {
                    for (int j = result + 1; j < array.Length - 1 - (i - result - 1); j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                // Вивід перетвореного масиву
                Console.WriteLine("Перетворений масив:");
                Console.WriteLine(string.Join(", ", array));
            }
        }

    }
}

