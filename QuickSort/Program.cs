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
            for (int i = 0; i < n; i++)
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
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low > high)
                return;


            //Partition list into two parts:
            //one containing elements less than or equal to pivot
            //Outher countaiming the elements greater then pivot

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //Search for element greater than pivot
                while ((arr[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;
                //Search for element smaller than pivot
                while ((arr[j] > pivot) && (j >= low))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;
                if (i < j)// if the greater elements is on the left of the elements
                {
                    //Swap the elements at index i with the elements at index
                    swap(i, j);
                    mov_count++;
                }

            }
            // j now contains the index of the last elements in the sorted list
            if (low < j)
            { // move the pivot to the its correct position in the list       
                swap(low, j);
                mov_count++;
            }
            // sort the list on the left of pivot using quick sort
            q_sort(low, j - 1);

            // sort the list on right of pivot using quick sort
            q_sort(j + 1, high);
        }

        void display()
        {
            Console.WriteLine("\n________________________________");
            Console.WriteLine(" Sorted Array Elements ");
            Console.WriteLine("________________________________");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]); 
            }

            Console.WriteLine("\nNumber of comparasion :" + cmp_count);
            Console.WriteLine("\nNumber of data movements:" + mov_count);


        }
        int getSize()
        {
            return (n);
        }


        static void Main(string[] args)
        {
            //Declaring the oblect of the class
            Program mylist = new Program();
            //accept array elements 
            mylist.input();
            //Calling the sorting function
            //First call to Quick sort Algorithm
            mylist.q_sort(0, mylist.getSize() - 1);
            //Display sorted array
            mylist.display();
            //to exit from the consoole
            Console.WriteLine("\n\nPress Enter to exit.");
            Console.Read();

        }
    }
}

