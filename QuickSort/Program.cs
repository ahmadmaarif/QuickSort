using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //array of integers to hold values 
        private int[] arr = new int[20];
        private int cmp_count = 0;//  number of data comparasion
        private int mov_count = 0; //number of data movements

        //Number of element in array 
        private int n;




        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can hame maximum 20 elements\n");
            }
            Console.WriteLine("\n======================");
            Console.WriteLine("enter Array Elements");
            Console.WriteLine("\n======================");

            //get array elements
            for(int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s = Console.ReadLine();
                arr[i] = Int32.Parse(s);
            }
        }
        // Swap the elements at index x with the elements at index y
        void swap(int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;

        }
        public void q_sort (int lowm, int high)
        {
            int voit, i, j;
            if (lowm > high)
                return;


            //Partition list into two parts:
            //one containing elements less than or equal to pivot
            //Outher countaiming the elements greater then pivot

            i = low + 1;
            j = high;

            voit = arr[i];
        }
        static void Main(string[] args)
        {
        }
    }
}
