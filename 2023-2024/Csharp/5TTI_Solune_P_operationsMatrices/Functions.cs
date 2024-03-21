using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_Solune_P_operationsMatrices
{
    internal class Functions
    {
        public static void creationMatrices(int[,] matrice1, int[,] matrice2, int M1Dim1, int M1Dim2, int M2Dim1, int M2Dim2)
        {
            Random randInt = new Random();
            matrice1 = new int[M1Dim1, M1Dim2];

            for (int i = 0; i < M1Dim1-1; i++)
            {
                for (int j = 0; i <M1Dim2-1; j++)
                {
                    matrice1[i, j] = randInt.Next(0, 10);
                }
            }

            matrice2 = new int[M2Dim1, M2Dim2];

            for (int i = 0; i < M2Dim1 - 1; i++)
            {
                for (int j = 0; i < M2Dim2 - 1; j++)
                {
                    matrice2[i, j] = randInt.Next(0, 10);
                }
            }
        }

        public static void ConcatenerMatrices(int[,] matrice1, int[,] matrice2, int[,] matriceFinal)
        {
            
        }
    }
}
