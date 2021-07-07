using System;

namespace Task_2_Assignment_1
{
    public class Transpose
    {
        public static void Main(string[] args)
        {
            int i, j, r, c;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];


            Console.Write("Welcome to my program\n\nTranspose of a Matrix\n");

            Console.Write("\nInput the number of rows and columns of the first matrix :\nRows : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Columns : ");
            c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe Given matrix is :\n");
            for (i = 0; i < r; i++)
            {
                Console.Write("\n");
                for (j = 0; j < c; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            for (i = 0; i < r; i++)
            {
                for (j = 0; j < c; j++)
                {

                    arr2[j, i] = arr1[i, j];
                }
            }

            Console.Write("\n\nThe Transpose of a matrix is : ");
            for (i = 0; i < c; i++)
            {
                Console.Write("\n");
                for (j = 0; j < r; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }
            Console.Write("\n\nThank you for using my program\n\n");
        }
    }
}