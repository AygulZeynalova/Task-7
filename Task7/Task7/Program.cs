using System.Diagnostics.Metrics;
using System.Drawing;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            int c = Readint("Insert the number c:");

            int len = Readint("How many numbers do you want in the array?");

            int[] a = new int[len];


            len = a.Length;

            for (int i = 0; i < len; i++)
            {

                a[i] = Readint($"Insert the {i + 1} number of the array");
            }
            for (int j = 0; j < len; j++)
            {
                if (a[j] < c)
                {

                    Console.Write(a[j]);
                }
            }
            #endregion

            #region Task 2
            int c1 = Readint("Insert the number c: ");
            int len1 = Readint("How many numbers do you want in the array?: ");
            int[] a1 = new int[len1];

            for (int i = 0; i < len1; i++)
            {
                a1[i] = Readint($"Insert the {i + 1} number of the array: ");
            }

            int sum = 0;
            int count = 0;

            for (int j = 0; j < len1; j++)
            {
                if (a1[j] < c1)
                {
                    sum += a1[j];
                    count++;
                }
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"The average of numbers less than c is: {average}");
            }
            else
            {
                Console.WriteLine("No numbers in the array are less than c.");
            }



            #endregion

            #region Task 3
            int C3 = Readint("Enter the value of C: ");


            int len3 = Readint("Enter the size of the array: ");
            int[] A3 = new int[len3];


            for (int i = 0; i < len3; i++)
            {
                A3[i] = Readint($"Enter element {i + 1}: ");
            }


            double answer = 1.0;
            int count3 = 0;

            for (int i = 0; i < len3; i++)
            {
                if (A3[i] > C3)
                {
                    answer *= A3[i];
                    count++;
                }
            }

            if (count > 0)
            {
                double geometricMean3 = Math.Pow(answer, 1.0 / count3);
                Console.WriteLine($"Geometric mean of numbers greater than C: {geometricMean3}");
            }
            else
            {
                Console.WriteLine($"No numbers in the array are greater than C.");
            }
            #endregion

            #region Task 4
            int c4 = Readint("Enter the value of C: ");
            int len4 = Readint("Enter the size of the array: ");
            int[] a4 = new int[len4];

            for (int i = 0; i < len4; i++)
            {
                a4[i] = Readint($"Enter element {i + 1}: ");
            }

            Array.Sort(a4);
            Array.Reverse(a4);

            Console.WriteLine($"Numbers in the array greater than {c4} in descending order:");
            foreach (var num in a4)
            {
                if (num > c4)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion

            #region Task 5
            int c5 = Readint("Enter the value of C: ");
            int len5 = Readint("Enter the size of the array: ");
            int[] a5 = new int[len5];
            Random rand5 = new Random();

            for (int i = 0; i < len5; i++)
            {
                a5[i] = rand5.Next(1, 100);
            }
            double greaterNum = double.MinValue;

            foreach (double num in a5)
            {
                if (num < c5 && num > greaterNum)
                {
                    greaterNum = num;
                }

            }
            if (greaterNum != double.MinValue)
            {
                Console.WriteLine($"The greatest number in the array that is lesser than C is:{greaterNum}");
            }
            else
            {
                Console.WriteLine("No number in the array is lesser than C");
            }
        #endregion

            #region Task 6
        l1:
            int len6 = Readint("Enter the size of the array: ");
            int[] x6 = new int[len6];
            int[] y6 = new int[len6];
            Random rand6 = new Random();

            for (int i = 0; i < len6; i++)
            {
                x6[i] = rand6.Next();
                y6[i] = rand6.Next();

            }

            bool found = false;

            for (int i = 0; i < len6; i++)
            {
                if (x6[i] == y6[i] * y6[i])
                {
                    Console.WriteLine($"x[{i}] = {x6[i]}, y[{i}] = {y6[i]}, and x[{i}] = y[{i}]^2");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("There are no elements in the array such that x[i] = y[i]^2.");
                goto l1;
            }
            #endregion

            #region Task 7

            int len7 = Readint("Enter the size of the array:");
            int[] a7 = new int[len7];

            Random rand7 = new Random();

            for (int i = 0; i < len7; i++)
            {
                a7[i] = rand7.Next(0, 100);
            }

            int min = a7[0];
            int max = a7[0];

            for (int i = 1; i < len7; i++)
            {
                if (a7[i] < min)
                {
                    min = a7[i];
                }

                if (a7[i] > max)
                {
                    max = a7[i];
                }
            }

            double arithmeticMean = (min + max) / 2.0;
            double geometricMean = Math.Sqrt(min * max);

            Console.WriteLine($"The smallest number in the array is {min} and the largest number is {max}.");
            Console.WriteLine($"The arithmetic mean of the smallest and largest numbers is {arithmeticMean}.");
            Console.WriteLine($"The geometric mean of the smallest and largest numbers is {geometricMean}.");

            #endregion

            #region Task 8

            int[] x8 = new int[14];
            int[] y8 = new int[14];
            Random rand8 = new Random();

            int[] results = new int[14];
            int count8 = 0;

            for (int i = 0;i < 14;i++)
            {
                x8[i] = rand8.Next();
                y6[i]= rand8.Next();

                int result8 = x8[i]*y6[i];
                if (result8 > 0)
                {
                    results[count8] = result8;
                     count8++;
                }
            }
            for (int i = 0; i < count8; i++)
            {
                Console.WriteLine(results[i]);
            }


            #endregion

            #region Task 9


            int[]a9= new int[25];  
            Random rand9 = new Random();
            for (int i = 0;i<25;i++)
            {
                a9[i] = rand9.Next();
            }
            int[]squaredArray= new int[8];
            int[] dividedArray = new int[25 - 8];

            for (int i = 0;i<8 ; i++)
            {
                squaredArray[i] = a9[i]* a9[i];
            }
            for(int i = 0;i<25 ; i++)
            {
                dividedArray[i - 8] = a9[i]/4;
            }
            Console.WriteLine("Squared array:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(squaredArray[i]);
            }

            Console.WriteLine("Divided array:");
            for (int i = 0; i < 25 - 8; i++)
            {
                Console.WriteLine(dividedArray[i]);
            }

        #endregion

            #region Task 10
       
            int len9 = Readint("Enter the size of the array:");

            int[] a10 = new int[len9];

            Random rand10 = new Random();

            for (int i = 0; i < len9; i++)
            {
                a10[i] = rand10.Next();
            }
            int maxNegative = int.MinValue;
            for (int i = 0; i < len9; i++)
            {
                if (a10[i] < 0 && a10[i] > maxNegative)//müəllim bu yolu copilotdan tapdım.Ancaq niyə  a10[i] > maxNegative olmalıdı anlamadım.
                {
                    maxNegative = a10[i];
                }
            }

            if (maxNegative != int.MinValue)
            {
                Console.WriteLine("The maximum negative number in the array is: " + maxNegative);
            }
            else
            {
                Console.WriteLine("There are no negative numbers in the array.");

            }
            #endregion

            #region Task 11

            int len11 = Readint("Enter the size of the array:");
            int[] x11 = new int[len11];

            Random rand11 = new Random();

            for (int i = 0; i < len11; i++)
            {
                x11[i] = rand11.Next(0, 100);
            }

            Array.Sort(x11);
            Array.Reverse(x11);

            Console.Write("The numbers of the array in descending order: ");
            for (int i = 0; i < len11; i++)
            {
                Console.Write(x11[i] + " ");
            }
            #endregion

            #region Task 12
            int[] x12 = new int[20];
            Random rand12 = new Random();

            for (int i = 0; i < x12.Length; i++)
            {
                x12[i] = rand12.Next();
            }

            int[] firstHalf = new int[10];
            int[] secondHalf = new int[20 - 10];

            double sum12 = 0;
            for (int i = 0; i < firstHalf.Length; i++)
            {
                sum12 += x12[i];
            }
            double arithmeticMean12 = sum12 / (firstHalf.Length);

            double product = 1;
            for (int i = 0; i < secondHalf.Length; i++)
            {
                product *= x12[i];
            }
            double geometricMean12 = Math.Pow(product, 1.0 / (secondHalf.Length));

            Console.WriteLine($"The arithmetic mean of the first half is:{arithmeticMean12}");
            Console.WriteLine($"The geometrical mean of second half is {geometricMean12}");
            #endregion





            #region Method
            static int Readint(string caption)
            {
            lr:
                Console.WriteLine(caption);
                string cStr = Console.ReadLine();
                bool state = int.TryParse(cStr, out int c);
                if (!state)
                {
                    Console.WriteLine("Insert a valid number:");
                    goto lr;
                }
                return c;
            }
            #endregion

















        }
    }
} 




