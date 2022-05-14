using System;
namespace Arrays_MultidimensionalArrays_JaggedArrays 
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal plan;
            {
                Console.Write("Enter the sales plan(ru): ");
                plan = Convert.ToDecimal(Console.ReadLine());
            }

            string[] surnamesArray;
            {
                Console.WriteLine("Enter employers' surnames with coma: ");
                string surnames = Console.ReadLine();
                surnamesArray = surnames.Split(',');

                for (int i = 0; i < surnamesArray.Length; i++)
                    surnamesArray[i] = surnamesArray[i].Trim();
            }

            decimal[][] jaggedArray;
            {
                jaggedArray = new decimal[surnamesArray.Length][];

                for (int i = 0; i < surnamesArray.Length; i++)
                {
                    Console.WriteLine($"Enter sum of sales by{surnamesArray[i]} with coma: ");
                    string sums = Console.ReadLine();
                    string[] sumsArray = sums.Split(',');
                    jaggedArray[i] = new decimal[sumsArray.Length];

                    for (int j = 0; j < sumsArray.Length; j++)
                    {
                        string sum = sumsArray[j].Trim();
                        jaggedArray[i][j] = Convert.ToDecimal(sum);
                    }
                }
            }

            decimal[] totalSumArray;
            {
                totalSumArray = new decimal[jaggedArray.Length];

                for (int i = 0; i < totalSumArray.Length; i++)
                {
                    decimal totalSum = 0;

                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        totalSum += jaggedArray[i][j];
                    }

                    totalSumArray[i] = totalSum;
                }
            }

            {
                for (int i = 0; i < totalSumArray.Length; i++)
                {
                    Console.Write($"{surnamesArray[i]} sold sold item with sum price {totalSumArray[i]} ru ");
                    decimal percent;

                    if(totalSumArray[i] < plan)
                    {
                        percent = (plan - totalSumArray[i]) / (plan / 100);
                        Console.WriteLine($"Plan not done {percent}%");
                    }
                    else if(totalSumArray[i] == plan)
                    {
                        Console.WriteLine("plan done 100%");
                    }
                    else if(totalSumArray[i] > plan)
                    {
                        percent = (totalSumArray[i] - plan) / (plan / 100);
                        Console.WriteLine($"plan overdonr {percent}%");
                    }
                }
            }

            {
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    Array.Sort(jaggedArray[i]);
                    int lastIndex = jaggedArray[i].Length - 1;
                    Console.WriteLine($"{surnamesArray}: min sale = {jaggedArray[i][0]}, max sale = {jaggedArray[i][lastIndex]}");
                }
            }
        }
    }
}