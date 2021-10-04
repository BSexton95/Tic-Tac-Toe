using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {      
            //Function that prints out the sume of each row of a 2D integer array of any size.
            void AddRows(int[,] array, int size1, int size2)
            {
                //Loop iterates through each row
                for (int i = 0; i < size1; i++)
                {

                    int sum = 0;

                    for (int j = 0; j < size2; j++)
                    {
                        sum = array[i, j] + sum;
                    }

                    Console.WriteLine(sum);
                }
            }

            /*
            //Lodis's example in class
            void AddRows(int[,] array)
            {
                //Loop interates through each row
                for (int i = 0; i < array.GetLength(0); i++)
                {

                    int sum = 0;

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }

                    Console.WriteLine(sum);
                }
            }
            */

            /*0  1  2*/
            int[,] array2DInitExample = new int[3, 3] { /*0*/{ 1, 2, 3 },
                                                        /*1*/{ 4, 5, 6 },
                                                        /*2*/{ 7, 8, 9 } };
            int[,] array2DInitExample2 = { { 1, 2, 3 },
                                           { 4, 5, 6 },
                                           { 7, 8, 9 },
                                           { 10, 11, 12 } };

            //Print out 2D array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array2DInitExample[i, j]);
                }
            }

            AddRows(array2DInitExample, 3, 3);
        }

    }
}
