using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectionSort selection = new SelectionSort(10);
            selection.SelectionSorting();
        }
    }
    class SelectionSort
    {
        private int[] myArray;
        private static Random generator = new Random();

        public SelectionSort(int size)
        {
            myArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                myArray[i] = generator.Next(20, 90);
            }
            Console.WriteLine("********** Original Random Array**********");
            DisplayArrayElements();
            Console.WriteLine("\n\n");
        }

　
        public void SelectionSorting()
        {
            for(int index=0;index<myArray.Length;index++)
            {
                int smallestIndex = index;

                for (int minIndex = index + 1; minIndex < myArray.Length; minIndex++)
                {
                    if (myArray[minIndex] < myArray[smallestIndex])
                    {
                        smallestIndex = minIndex;
                    }
                }
                Swap(index, smallestIndex);
            }
            Console.WriteLine("********** Sorted Array*****************");
            DisplayArrayElements();
            Console.ReadKey(); 
        }

        private void DisplayArrayElements()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "  ");
            }
        }

        private void Swap(int first, int second)
        {
            int temporary = myArray[first];
            myArray[first] = myArray[second];
            myArray[second] = temporary; 
        }
    }
}
