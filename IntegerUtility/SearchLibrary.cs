using System;

namespace IntegerUtility
{
    public class SearchLibrary
    {
        /// <summary>
        /// Finds the first and only unpaired integer in the array provided.
        /// </summary>
        /// <param name="A">Integer array of pairs of integers with a single unpaired integer.</param>
        /// <returns>The only unpaired element in the array, returns -1 when none or more than one (ambigious) is found.</returns>
        public int FindUnpairedElement(int[] A)
        {
            //If there are an even number of elements error immediately
            if (A.Length %2 == 0) throw new System.ApplicationException("No unpaired integer found or multiple ambigious matches.");

            Array.Sort(A);          //Arranges all pairs next to each other
            int firstIndex = FindUnpairedElementIndex(A, 0);

            //Check this is the one and only.
            if (firstIndex > -1 && FindUnpairedElementIndex(A, firstIndex + 1) == -1) return A[firstIndex];

            //How to return no result? Throw exception or not a number (-1 not cool)? Ideally change the method call signature to have an outref and bool
            throw new System.ApplicationException("No unpaired integer found or multiple ambigious matches.");
        }

        /// <summary>
        /// Returns the index of the single element in the sorted array.
        /// </summary>
        /// <param name="myArray"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        protected int FindUnpairedElementIndex(int[] myArray, int start)
        {
            for (int i = start; i < myArray.Length - start; i++)
            {
                if (i==myArray.Length - 1 || myArray[i] != myArray[i + 1])
                    return i;
                i++;
            }

            return -1;
        }

        /// <summary>
        /// Old algorithm included for reference (and black box testing)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        //public int singleNumber(int A[], int n)
        //{
        //    int min = A[0];
        //    for (int i = 1; i < n; i++)
        //    {
        //        if (A[i] < min)
        //        {
        //            min = A[i];
        //        }
        //    }

        //    int kmin = min + 1;

        //    do
        //    {
        //        int flag = 0;
        //        for (int i = 0; i < n; i++)
        //        {
        //            if (A[i] == kmin)
        //            {
        //                flag = 1; // we cannot use this number
        //                break;
        //            }
        //        }
        //        if (flag == 0) break;
        //        kmin++;
        //    } while (true);

        //    for (int i = 0; i < n; i++)
        //    {
        //        if (A[i] == kmin)
        //            continue; // has appeared before

        //        int c = 0;
        //        int k = A[i];
        //        A[i] = kmin;
        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (A[j] == k)
        //            {
        //                c++;
        //                A[j] = kmin; // mark this so to skip next time
        //                if (c == 1) break; // maximum twice
        //            }
        //        }
        //        if (c != 1) return k;
        //    }
        //}

    }
}
