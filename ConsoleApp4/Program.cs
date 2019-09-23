using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Statement
{
    class Program
        {
            public static void Main()
            {
                
                int large, small;
                int[] arr = new int[50];
                Console.WriteLine("Enter the size of an Array :--> ");
               int n = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the array elements");
                for (int i = 0; i < n; i++)
                {
                   
                    arr[i] = Int32.Parse(Console.ReadLine());
                }
                Console.Write("");
                large = arr[0];
                small = arr[0];
                for (int i = 1; i < n; i++)
                {
                    if (arr[i] > large)
                        large = arr[i];
                    else if (arr[i] < small)
                        small = arr[i];
                }
                Console.WriteLine("Largest element in the array is {0}", large);
                Console.WriteLine("Smallest element in the array is {0}", small);
            Console.ReadLine();
            }
        }

    }
