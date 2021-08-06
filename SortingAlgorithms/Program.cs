﻿using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Sorting Algorithms *****");
            List<int> array = new List<int>() {59, 10, 56, 26, 11, 87, 24, 88, 75, 37};
            DisplayArray(array);
            
            // Bubble sort
            DisplayArray(BubbleSort.Sort(array));
        }

        static void DisplayArray(List<int> array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
