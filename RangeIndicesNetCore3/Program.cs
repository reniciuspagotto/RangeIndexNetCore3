using System;

namespace RangeIndicesNetCore3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTest = { 0, 5, 10, 15, 20, 25 };
            var result = arrayTest[0..^3];

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var text = "Microsoft anuncia C# 8.0";

            string range = text[^24..^2];
            Console.WriteLine(range);

            string range3 = text[^14..];
            Console.WriteLine(range3);

            string range4 = text[..9];
            Console.WriteLine(range4);

            var data = GetRange(arrayTest, 0, 4);

            foreach (var item in data)
                Console.WriteLine(item);

            Console.ReadKey();
        }

        public static Array GetRange(int[] array, Index startIndex, Index endIndex)
        {
            var data = array[startIndex..endIndex];
            return data;
        }
    }
}
