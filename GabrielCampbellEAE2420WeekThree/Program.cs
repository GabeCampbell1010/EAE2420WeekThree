using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gabriel Campbell u0861355

namespace GabrielCampbellEAE2420WeekThree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> orderedList = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9 };
            List<int> unorderedList = new List<int> { 5, 1, 3, 0, 6, 2, 4, 7 };

            //Question 1:
            //Console.WriteLine(ReturnIndexGreaterOrEqual(5, orderedList));
            //PrintList(orderedList);
            //Shift(ref orderedList, 4);
            //Insertion(ref orderedList, 5);
            //PrintList(orderedList);
            //PrintList(Random(5));
            //CreateAndInsert();

            //BubbleSort:
            //foreach (int n in BubbleSort.Sort(unorderedList))
            //{
            //    Console.Write(n + " ");
            //}
            //Console.WriteLine();

            //InsertionSort:
            //List<int> insertionSortedList = InsertionSort.Sort(unorderedList);
            //foreach (int item in insertionSortedList)
            //{
            //    Console.Write(item + " ");
            //}

            //MergeSort
            //int[] array = new int[] { 9, 8, 5, 4, 1, 2, 7, 0, 3, 6 };
            //MergeSort.Sort(array);
            //foreach (var n in array)
            //{
            //    Console.Write(n + " ");
            //}

            //QuickSort
            int[] arrayQuick = new int[] { 9, 8, 5, 4, 1, 2, 7, 0, 3, 6 };
            QuickSort.Sort(arrayQuick);
            foreach (var n in arrayQuick)
            {
                Console.Write(n + " ");
            }



            Console.ReadKey();

        }

        public static void PrintList(List<int> list)
        {
            foreach (int n in list)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        public static int ReturnIndexGreaterOrEqual(int value, List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= value)
                    Debug.Assert(list[i] >= value);
                return i;
            }
            return list.Count;
        }

        public static void Shift(ref List<int> list, int index)
        {
            List<int> tempList = new List<int>(list);
            tempList.Add(0);
            //Console.WriteLine(tempList.Count);
            //Console.WriteLine(list.Count);

            for (int i = list.Count() - 1; i >= index; i--)
            {
                tempList[i + 1] = tempList[i];
            }
            tempList[index + 1] = 0;
            list = tempList;
        }

        public static void Insertion(ref List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= value)
                {
                    int temp = list[i];
                    Shift(ref list, i);
                    list[i + 1] = temp;
                    list[i] = value;
                    return;
                }
            }
        }

        public static List<int> Random(int n)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            int num = 0;
            int prevNum = 0;

            for (int i = 0; i < n; i++)
            {
                num = rand.Next(2, 5);//hardcoded values, should start from at least 2 though to prevent sequential values
                list.Add(num + prevNum);
                prevNum = list[i];
            }

            //tests for sequential or not in order values
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1] || list[i] == (list[i + 1] + 1))
                {
                    throw new Exception("identical or sequential values detected");
                }
                if (list[i] > list[i + 1])
                {
                    throw new Exception("elements not in order detected");
                }

            }

            return list;

        }

        public static void CreateAndInsert()//i think that maybe the instructions are supposed to ask us something more like insert a random value a million times
        {//because right now it happens instantly
            StringBuilder csv = new StringBuilder();
            Random num = new Random();


            for (int i = 100; i <= 10000; i += 100)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < i; j++)
                {
                    list.Add(j);//just add a value matching each index
                }

                int ran = num.Next(0, i);
                
                System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();//start stopwatch
                Insertion(ref list, ran);//just do one insertion per list?//list sizes all go up by 1 because of the insertion btw
                watch.Stop();//end stopwatch

                //Console.WriteLine("inserted: " + ran);
                
                long timeElapsedInMilliseconds = watch.ElapsedMilliseconds;//time elapses for a million searches on list of size i

                Console.WriteLine("A list of size: {0} took {1} milliseconds to insert a random number", list.Count, timeElapsedInMilliseconds);
                string newLine = $"{list.Count},{timeElapsedInMilliseconds}";
                csv.AppendLine(newLine);
            }
            string filePath = @"C:\Users\Gabe\Documents\Insertion.ods";//this was the file path local to my computer of course
            string csvString = csv.ToString();
            File.WriteAllText(filePath, csvString);
            Console.ReadKey();

        }



    }
}
