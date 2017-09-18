using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCampbellEAE2420WeekThree
{
    class MergeSort
    {
        public static List<int> Sort(List<int> list)
        {
            List<List<int>> listOfArrays = new List<List<int>>();



            for (int i = 0; i < list.Count; i+=2)//this for loop establishes the inital arrays of all size 2 and sorted
            {
                List<int> tempArray = new List<int>() { 0,0 };
                tempArray[0] = list[i];
                tempArray[1] = list[i + 1];
                if(tempArray[0] > tempArray[1])
                {
                    int temp = tempArray[0];
                    tempArray[0] = tempArray[1];
                    tempArray[1] = temp;
                }
                foreach (int n in tempArray)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
                listOfArrays.Add(tempArray);
            }
            //listOfArrays.Add(new List<int> { 1});

            List<List<int>> listOfArraysSizeFour = new List<List<int>>();

            for (int i = 0; i < listOfArrays.Count; i+=2)//iterate up through two arrays each time
            {
                List<int> tempArray = new List<int>() {0,0,0,0 };

                int k = 0;
                int j = 0;

                listOfArrays[i].Add(1);
                listOfArrays[i+1].Add(0);


                for (int m = 0; m < tempArray.Count; m++)//iterate across the length of one of the arrays in the list of arrays
                {
                    if(listOfArrays[i][j] < listOfArrays[i + 1][k])
                    {
                        tempArray[m] = listOfArrays[i][j];
                        j++;
                    }
                    else
                    {
                        tempArray[m] = listOfArrays[i+1][k];
                        k++;
                    }
                }
                listOfArraysSizeFour.Add(tempArray);
            }

            for (int i = 0; i < listOfArraysSizeFour.Count; i++)
            {
                foreach (var n in listOfArraysSizeFour[i])
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }

            return list;
        }


    }
}

/*
  List<int[]> listOfArrays = new List<int[]>();

            int subArraySizeCount = 2;

            for (int i = 0; i < list.Count; i+=subArraySizeCount)
            {
                int[] tempArray = new int[subArraySizeCount];

                int k = 0;

                for (int j = 0; j < subArraySizeCount; j++)
                {
                    tempArray[j] = list[k];
                    k++;
                }

                tempArray[0] = list[i];
                tempArray[1] = list[i + 1];
                //if(tempArray[0] > tempArray[1])//this needs to be replaced with sorting in general for a list of n size
                //{
                //    int temp = tempArray[0];
                //    tempArray[0] = tempArray[1];
                //    tempArray[1] = temp;
                //}
                foreach (int n in tempArray)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
                listOfArrays.Add(tempArray);
            }

            for (int i = 0; i < listOfArrays.Count; i++)
            {
                int[] tempArray = new int[4];
            }

            return list;
     */
