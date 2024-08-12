using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04_Advaced_C_
{
    // delegate
    public delegate bool ConditionFancDelegate(int A, int B);
    public delegate bool ConditionFancDelegatev02(string A, string B);
    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] Arr , ConditionFancDelegate  referance)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for(int j = 0; j< Arr.Length-i-1; j++)
                    {
                        if (referance.Invoke(Arr[j], Arr[j + 1]))
                        {
                            Swap(ref Arr[j], ref Arr[j+1]);
                        }
                    }
                }
            }
        } public static void BubbleSort(string[] Arr , ConditionFancDelegatev02  referance)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for(int j = 0; j< Arr.Length-i-1; j++)
                    {
                        if (referance.Invoke(Arr[j], Arr[j + 1]))
                        {
                            Swap(ref Arr[j], ref Arr[j+1]);
                        }
                    }
                }
            }
        }   
        

        // public static void BubbleSortDes(int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for(int j = 0; j< Arr.Length-i-1; j++)
        //            {
        //                if (SortingFunctions.Less(Arr[j], Arr[j+1]))
        //                {
        //                    Swap(ref Arr[j], ref Arr[j+1]);
        //                }
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSort(int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for(int j = 0; j< Arr.Length-i-1; j++)
        //            {
        //                if(Arr[j] > Arr[j + 1])
        //                {
        //                    Swap(ref Arr[j], ref Arr[j+1]);
        //                }
        //            }
        //        }
        //    }
        //} 

        //public static void BubbleSortDes(int[] Arr)
        //{
        //    if (Arr is not null)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for(int j = 0; j< Arr.Length-i-1; j++)
        //            {
        //                if(Arr[j] < Arr[j + 1])
        //                {
        //                    Swap(ref Arr[j], ref Arr[j+1]);
        //                }
        //            }
        //        }
        //    }
        //}

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x=y; 
            y=temp;

        } public static void Swap(ref string x, ref string y)
        {
            string temp = x;
            x=y; 
            y=temp;

        }


    } 

    class SortingFunctions
    {
        public static bool Gtr(string L, string R)
        {
            return (L.Length> R.Length);
        } 
        public static bool Less(string L, string R)
        {
            return (L.Length< R.Length);
        }public static bool Gtr(int L, int R)
        {
            return (L> R);
        } 
        public static bool Less(int L, int R)
        {
            return (L< R);
        }
    }
}
