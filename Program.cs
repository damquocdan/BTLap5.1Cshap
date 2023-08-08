using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BTLap5._1Cshap
{
    internal class Program

    {
        public static void PrintArray(int[] x)
        {
            foreach (int num in x)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        public static bool IsPrime(int x)
        {
            if (x <= 1)
                return false;

            if (x <= 3)
                return true;

            if (x % 2 == 0 || x % 3 == 0)
                return false;

            for (int i = 5; i * i <= x; i += 6)
            {
                if (x % i == 0 || x % (i + 2) == 0)
                    return false;
            }

            return true;
        }
        public static int FindMaxConsecutivePositive(int[] arr)
        {
            int maxCount = 0;
            int currentCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 0;
                }
            }

            return maxCount;
        }

        public static double CalculateAveragePositive(int[] arr)
        {
            int positiveCount = 0;
            int positiveSum = 0;

            foreach (int num in arr)
            {
                if (num > 0)
                {
                    positiveCount++;
                    positiveSum += num;
                }
            }

            if (positiveCount > 0)
            {
                return (double)positiveSum / positiveCount;
            }
            else
            {
                return 0;
            }
        }

        public static bool CheckAlternatingPositiveNegative(int[] arr)
        {
            bool isPositive = arr[0] > 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if ((isPositive && arr[i] > 0) || (!isPositive && arr[i] < 0))
                {
                    return false;
                }

                isPositive = !isPositive;
            }

            return true;
        }



        static void Main(string[] args)
        {
            int[] x= {1,2,3,4,5,45,345,32,12,23};
            Console.WriteLine();
            PrintArray(x);
            int minValue = x.Min();
            Console.Write("gia tri nho nhât cua mang:"+minValue);
            Array.Reverse(x);
            Console.Write("dao nguoc mang:");
            foreach (int i in x) Console.WriteLine(i + "\t");

            Array.Sort(x);
            Console.WriteLine("sap xep mang");
            foreach (int i in x) Console.WriteLine(i + "");
            Console.WriteLine("tim phan tu la so nguyen to:");
            foreach(int i in x)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + "");
                }
            }
            Console.WriteLine();
            int maxConsecutivePositive = FindMaxConsecutivePositive(x);
            Console.WriteLine("So luong cac so duong liên tiêp nhiêu nhât: " + maxConsecutivePositive);

            
            double averagePositive = CalculateAveragePositive(x);
            Console.WriteLine("Tinh trung binh cong cac phan tu duong: " + averagePositive);

            
            bool isAlternating = CheckAlternatingPositiveNegative(x);
            Console.WriteLine("mang co chua cac phan tu am duong dan xen nhau khong: " + isAlternating);





            Console.ReadKey ();

        }
    }
}