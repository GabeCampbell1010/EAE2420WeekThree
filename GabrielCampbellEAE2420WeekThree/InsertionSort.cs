using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCampbellEAE2420WeekThree
{
    class InsertionSort
    {
        public static List<int> Sort(List<int> list)
        {
            int valueToMove;
            //foreach value in the unsorted list, check if it is smaller than the previous value, if so remove it, then find the spot where it belongs, shift everything after that spot up to the removed spot by one, and insert it at that spot

            for (int i = 1; i < list.Count; i++)
            {
                if(list[i] < list[i - 1])
                {
                    valueToMove = list[i];
                    for (int j = 0; j < i; j++)
                    {
                        if (list[j] >= valueToMove)//find new spot
                        {
                            Shift(ref list, j, i, valueToMove);
                            break;
                        }
                    }
                }
            }


            return list;
        }


        public static void Shift(ref List<int> list, int indexOfNewSpot, int indexOfOldSpot, int valueToMove)//indexes and values to move are tentatively correct
        {
            List<int> tempList = new List<int>(list);
            //tempList.Add(0);//don't have to add because should automatically remove the right spot with the shifting
            //Console.WriteLine(tempList.Count);
            //Console.WriteLine(list.Count);

            for (int i = indexOfOldSpot; i > indexOfNewSpot; i--)
            {
                tempList[i] = tempList[i-1];
            }
            tempList[indexOfNewSpot] = valueToMove;
            list = tempList;
        }
    }
}
