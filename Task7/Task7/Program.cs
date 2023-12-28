using System.Drawing;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //int c = Readint("Insert the number c:");

            //int len = Readint("How many numbers do you want in the array?");

            //int[] a = new int[len];


            //len = a.Length;

            //for (int i = 0; i < len; i++)
            //{

            //    a[i] = Readint($"Insert the {i + 1} number of the array");
            //}
            //for (int j = 0; j < len; j++)
            //{
            //    if (a[j] < c)
            //    {

            //        Console.Write(a[j]);
            //    }
            //}
            #endregion

            #region Task 2
            //int c1 = Readint("Insert the number c: ");
            //int len1 = Readint("How many numbers do you want in the array?: ");
            //int[] a1 = new int[len1];

            //for (int i = 0; i < len1; i++)
            //{
            //    a1[i] = Readint($"Insert the {i + 1} number of the array: ");
            //}

            //int sum = 0;
            //int count = 0;

            //for (int j = 0; j < len1; j++)
            //{
            //    if (a1[j] < c1)
            //    {
            //        sum += a1[j];
            //        count++;
            //    }
            //}

            //if (count > 0)
            //{
            //    double average = (double)sum / count;
            //    Console.WriteLine($"The average of numbers less than c is: {average}");
            //}
            //else
            //{
            //    Console.WriteLine("No numbers in the array are less than c.");
            //}



            #endregion

            #region Task 3
            //int C3 = Readint("Enter the value of C: ");


            //int len3 = Readint("Enter the size of the array: ");
            //int[] A3 = new int[len3];


            //for (int i = 0; i < len3; i++)
            //{
            //    A3[i] = Readint($"Enter element {i + 1}: ");
            //}


            //double answer = 1.0;
            //int count1 = 0;

            //for (int i = 0; i < len3; i++)
            //{
            //    if (A3[i] > C3)
            //    {
            //        answer *= A3[i];
            //        count++;
            //    }
            //}

            //if (count > 0)
            //{
            //    double geometricMean = Math.Pow(answer, 1.0 / count);
            //    Console.WriteLine($"Geometric mean of numbers greater than C: {geometricMean}");
            //}
            //else
            //{
            //    Console.WriteLine($"No numbers in the array are greater than C.");
            //}
            #endregion

            #region Task 4
            //int c4 = Readint("Enter the value of C: ");
            //int len4 = Readint("Enter the size of the array: ");
            //int[] a4 = new int[len4];

            //for (int i = 0; i < len4; i++)
            //{
            //    a4[i] = Readint($"Enter element {i + 1}: ");
            //}

            //Array.Sort(a4);
            //Array.Reverse(a4);

            //Console.WriteLine($"Numbers in the array greater than {c4} in descending order:");
            //foreach (var num in a4)
            //{
            //    if (num > c4)
            //    {
            //        Console.WriteLine(num);
            //    }
            //} 
            #endregion




        }







            #region Method
            static int Readint(string caption)

            {
            l1:
                Console.WriteLine(caption);
                string cStr = Console.ReadLine();
                bool state = int.TryParse(cStr, out int c);
                if (!state)
                {
                    Console.WriteLine("Insert a valid number:");
                    goto l1;
                }
                return c;
            }
            #endregion















        
    }
}

