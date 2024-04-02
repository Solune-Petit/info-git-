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

        public static void ConcatenerMatrices(int[,] matrice1, out string concatene)
        {
            concatene = "";
            string ligne;
            for (int i = 0;i < matrice1.GetLength(0)-1; i++)
            {
                ligne = "";
                for (int j = 0; j < matrice1.GetLength(0)-1 ; j++)
                {
                    ligne = ligne + matrice1[i, j];
                    if (j != matrice1.GetLength(1)-1)
                    {
                        ligne = ligne + " ";
                    }
                    else
                    {

                    }
                }
                concatene = concatene + "\n" + ligne;
            }
        }

        public static void additionnerMatrices(int[,] matrice1, int[,] matrice2, int[,] matriceFinale, out bool ok )
        {
            ok = true;
            if (matrice1.GetLength(0) ==  matrice2.GetLength(0) && matrice1.GetLength(1) == matrice2.GetLength(2))
            {
                for (int i = 0; i < matrice1.GetLength(0) - 1; i++)
                {
                    for (int j = 0;j < matrice1.GetLength(1)- 1 ; j++)
                    {
                        matriceFinale[i,j] = matrice1[i,j] + matrice2[i,j];
                    }
                }
            }
            else
            {
                ok = false;
            }
        }

        public static void multiplicationMatrice(int[,] matrice1, int[,] matrice2, int[,] matriceFinale, out bool ok)
        {
            if (matrice1.GetLength(0) == matrice2.GetLength(0))
            {
                ok = true;
                for (int i = 0;i < matrice1.GetLength(0)-1; i++)
                {
                    for (int j = 0; j < matrice2.GetLength(1)-1 ; j++)
                    {
                        matriceFinale[i, j] = 0;

                        for (int k = 0; k < matrice1.GetLength(1)-1; k++)
                        {
                            matriceFinale[i, k] += matrice1[i, k] * matrice2[k, j];
                        }
                    }
                }
            }
        }
    }
}
