using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsAndArrays
{
    class ListsAndArrays
    {
        static void Main(string[] args)
        {
            int[] table = {4, -1, 45, 7, 0, 3, -9, 9};

            List<int> integerList = new List<int>() {4, -1, 45, 7, 0, 3, -9, 9};            

            string sentence =  "Niech to będzie zdanie , gdzie szukamy litery 'i'";
            char character = 'i';

            Console.WriteLine("Sum numbers of table [{0}] is equal {1}", string.Join(" ", table), SumArray(table));
            Console.WriteLine("Sum of the number is equal {0}", SumList(integerList));
            Console.WriteLine("Minimal number is equal {0}", MinArray(table));
            Console.WriteLine("Minimal number is equal {0}", MinList(integerList));
            Console.WriteLine("Maximum number is equal {0}", MaxArray(table));
            Console.WriteLine("Maximum number is equal {0}", MaxList(integerList));
            Console.WriteLine("Avarage of numbers is equal {0}", AvgArray(table));
            Console.WriteLine("Avarage of numbers is equal {0}", AvgList(integerList));

            Console.WriteLine("Number of table [{0}] are sorted in following way: [{1}]", string.Join(" ", table), string.Join(" ", Sort(table)));

            Console.WriteLine($"Character {character} occurs in {sentence} {CountCharacters(sentence, character)}  times");
            Console.Read();

        }

        public static int CountCharacters(string text, char character)
        {
            int number = 0;

                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i] == character)
                    {
                        number++;
                    }
                }

            return number;
        }

        public static int SumArray(int[] table)
        {
            var sum = 0;

            for (int i = 0; i < table.Length; i++)
            {
                sum = sum + table[i];
            }

            return sum ;
        }

        public static int SumList(List<int> list)
        {
            var sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

        public static int MinArray(int[] table)
        {
            var min = 0;

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] < min)
                {
                    min = table[i];
                }
            }

            return min;
        }

        public static int MinList(List<int> list)
        {
            var min = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i) < min)
                {
                    min = list[i];
                }
            }

            return min;
        }

        public static int MaxArray(int[] table)
        {
            var max = 0;

            for (int j = 0; j < table.Length; j++)
            {
                if (table[j] > max)
                {
                    max = table[j];
                }
            }

            return max;
        }

        public static int MaxList(List<int> list)
        {
            return list.Select((t, j) => list.ElementAt(j)).Concat(new[] {0}).Max();
        }

        public static int AvgArray(int[] table)
        {
            return SumArray(table) /table.Length;
        }

        public static int AvgList(List<int> list)
        {
            return SumList(list) / list.Count;
        }


        static void PrintTable(int[] table)
        {
            Console.Write("Contents of table: ");

            // Iterate through elements and write
            for (int i = 0; i < table.Length; i++)
            {
                int value = table[i];
                Console.Write("{0} ", value);
            }

            Console.WriteLine();
        }


        static int[] Sort(int[] table)
        {
            for (int sortedElements = 0; sortedElements < table.Length; sortedElements++)
            {
                int minimumIndex = GetMinValueIndex(table, sortedElements);
                SwapValues(table, minimumIndex, sortedElements);
            }

            return table;
        }

        private static int[] SwapValues(int[] table, int indexA, int indexB)
        {
            int temp = table[indexA];
            table[indexA] = table[indexB];
            table[indexB] = temp;

            return table;

        }
  
        static int GetMinValueIndex(int[] array, int fromIndex)
        {
            int minumumIndex = fromIndex;

            for (int i = fromIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minumumIndex])
                {
                    minumumIndex = i;
                }
            }

            return minumumIndex;
        }

        private static string Reverse(string text)
        {
            string result = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result = result + text[i];
            }

            return result;
        }

        private static string Reverse2(string text)
        {
            // String to char[] --> .ToCharArray()
            char[] array = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = text[i];
            }

            // Implementation
            for (int i = 0; i < text.Length / 2; i++)
            {
                //array[0] <--> array[text.Length-1]
                // array[0+i] <--> array[text.Length-1 -i]
                char temp = array[i];
                array[i] = array[text.Length - 1 - i];
                array[text.Length - 1 - i] = temp;
            }

            // new string(array)
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result = result + array[i];
            }

            return result;
        }
    }
}
