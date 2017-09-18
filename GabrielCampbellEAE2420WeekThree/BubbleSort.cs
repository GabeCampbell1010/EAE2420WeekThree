using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCampbellEAE2420WeekThree
{
    class BubbleSort
    {
        public static List<int> Sort(List<int> list)
        {
            int temp;
            while (!SortCheck(list))
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
            }


            return list;
        }

        public static bool SortCheck(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
