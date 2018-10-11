using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Smallest_Numbers_In_A_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            Console.WriteLine("list: ");
            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("smallest:");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list");
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "count should be between 1 and numbers of elements in the list.");
            var buffer = new List<int>(list);
            var smallests = new List<int>();
            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}

