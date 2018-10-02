using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindMaxSubmatrix
{
    class FindMaxSubmatrix
    {
        static int[][] ReadMatrix(string pathFile)
        {

            try
            {
                StreamReader reader = new StreamReader(pathFile, Encoding.Default);
                int sizeOfMatrix = 0;
                
                string line = null;
                using (reader)
                {
                    sizeOfMatrix = int.Parse(reader.ReadLine());
                    int[][] matrix = new int[sizeOfMatrix][];
                    for (int i = 0; i < sizeOfMatrix; i++)
                    {
                        matrix[i] = new int[sizeOfMatrix];
                    }
                    string[][] matrixText = new string[sizeOfMatrix][];
                    for (int i = 0; i < sizeOfMatrix; i++)
                    {
                        matrixText[i] = new string[sizeOfMatrix];
                    }
                    line = reader.ReadLine();
                    for (int i = 0; i < sizeOfMatrix; i++)
                    {
                        matrixText[i] = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        line = reader.ReadLine();
                    }
                    for (int i = 0; i < sizeOfMatrix; i++)
                    {
                        for (int j = 0; j < sizeOfMatrix; j++)
                        {                            
                            matrix[i][j] = int.Parse(matrixText[i][j]);
                            Console.Write(matrix[i][j]+" ");
                        }
                        Console.WriteLine();
                    }
                    return matrix;
                }

                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("FNF");
                throw e;
            }
            catch (FormatException e)
            {
                Console.WriteLine("something is not integer!");
                throw e;
            }

        }

        static int[][] FindMaxSubMatrix(int[][] matrix)
        {
            int[][] subMatrix = new int[2][];
            
            int valueSubMatrix = 0;
            int maxValue = 0;
            int startIndexX = 0;
            int startIndexY = 0;
            for (int i = 0; i < subMatrix.Length; i++)
            {
                subMatrix[i] = new int[2];
            }
            for (int i = 0; i < matrix.Length-1; i++)
            {
                for (int j = 0; j < matrix[i].Length-1; j++)
                {
                    valueSubMatrix = matrix[i][j] + matrix[i][j+1] + matrix[i+1][j] + matrix[i+1][j+1];
                    if (valueSubMatrix>maxValue)
                    {
                        maxValue = valueSubMatrix;
                        startIndexX = i; // or vice versa???
                        startIndexY = j;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    subMatrix[i][j] = matrix[startIndexX+i][startIndexY+j];
                }
            }
            return subMatrix;
        }

        static void Main(string[] args)
        {
            string path = @"..\..\TextDoc1.txt";
            int[][] matrix = ReadMatrix(path);
            int[][] maxSubMatrix = FindMaxSubMatrix(matrix);
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(maxSubMatrix[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
