using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 2, 9, 4,6,3,8,5,3,6 };
            TrySort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
        

        public static int [] TrySort(int [] arr)
        {
            int j = 0;
            for (int i = j + 1; i < arr.Length; i++)
            {
                if(arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = arr[i];
                }
                if(i == arr.Length - 1)
                {
                    j++;
                }
                
            }
            return arr;
        }
        public static int[] Sort(int[] arr)
        {
            bool flag = true;
            int temp = 0;
            //takes care of the n - 1 priciple for ensuring the solution is fully sorted
            for (int i = 1; i < arr.Length - 1 && flag; i++)
            {
                //bool tells if there was a swap or not
                flag = false;
                //set to < length -1 because we are looking at the next element
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    //swap
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            return arr;
        }
    }
}
