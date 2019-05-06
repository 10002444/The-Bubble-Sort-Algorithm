using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Bubble_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[1000];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1000);
            };

            Console.WriteLine("");
            Console.WriteLine("Random Numbers:");

            foreach (int x in nums)
                Console.Write(x + " ");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sorted Numbers:");

            BubbleSort(nums);
            Display(nums);

        }
        static int[] BubbleSort(int[] arr)
        {
            bool swap = true;
            /*External loop makes sure we check all of array*/
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swap = false;
                /*Internal loop goes through the elements and checks each one and subtracts i as the largest element in the array is at the end now*/
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    /*If the current element is larger than the next element, swap them*/
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        /*check if any swaps have been made for data thats in near order*/
                        swap = true;
                    }
                }
                /*If no swaps are made break*/
                if (!swap)
                    break;
            }
            /*Retuern the sorted array*/
            return arr;
        }

        /*Display the array*/
        static void Display<T>(T[] arr)
        {
            foreach (T x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}
