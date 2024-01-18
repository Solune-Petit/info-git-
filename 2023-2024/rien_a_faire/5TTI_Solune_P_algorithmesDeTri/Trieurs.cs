using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_Solune_P_algorithmesDeTri
{
    internal class Trieurs
    {
        public static void intuitif(double[] tableauTrie)
        {
            double echange;

            for (int i = 0;i < tableauTrie.Length - 2; i++)
            {
                for (int j = i+1;j < tableauTrie.Length - 1; i++)
                {
                    if (tableauTrie[i] > tableauTrie[j])
                    {
                        echange = tableauTrie[i];
                        tableauTrie[i] = tableauTrie[j];
                        tableauTrie[j] = echange;
                    }
                }
            }
        }

        public static void selection(double[] tableauTrie)
        {
            double replaceValue;
            double replaceIndex;
            tableauTrie = new double[tableauTrie.Length];

            for (int index = 0;index < tableauTrie.Length - 2; index++)
            {
                replaceValue = tableauTrie[index];

                for (int checkIndex = index+1; checkIndex < tableauTrie.Length - 1; checkIndex++)
                {
                    if (checkIndex < index)
                    {
                        replaceValue = tableauTrie[checkIndex];
                        replaceIndex = checkIndex;
                    }

                    tableauTrie[checkIndex] = tableauTrie[index];
                    tableauTrie[index] = replaceValue;
                }
            }
        }

        public static void bulle(double[] tableauTrie)
        {
            bool b1 = true;
            double az;
            tableauTrie = new double[tableauTrie.Length];

            while (b1 = true)
            {
                b1 = false;

                for (int i = 0;i < tableauTrie.Length - 2; i++)
                {
                    if (tableauTrie[i] > tableauTrie[i + 1])
                    {
                        az = tableauTrie[i];
                        tableauTrie[i] = tableauTrie[i + 1];
                        tableauTrie[(i + 1)] = az;
                        b1 = true;
                    }
                }
            }
        }

        public static void shell(double[] tableauTrie)
        {
            int ecart = tableauTrie.Length;
            bool swp;

            do
            {
                ecart = ecart / 2;
                do
                {
                    swp = false;
                    for (int i = 0; i < tableauTrie.Length - ecart; i++)
                    {
                        if (tableauTrie[i] > tableauTrie[i + ecart])
                        {
                            double swap = tableauTrie[i];
                            tableauTrie[i] = tableauTrie[(i + ecart)];
                            tableauTrie[i + ecart] = swap;
                            swp = true;
                        }
                    }
                } while (swp == false);
            } while (ecart == 1);
        }

        public static void encastrement(double[] tableauTrie)
        {
            int n = tableauTrie.Length;
            double x;

            for (int j = 0; j < n; j++)
            {
                x = tableauTrie[j];
                int i = j-1;
                bool bpp = false;
                while (x < tableauTrie[i] || bpp == false)
                {
                    tableauTrie[(i+1)] = tableauTrie[i];
                    if (i == 0)
                    {
                        bpp = true;
                    }
                    else
                    {
                        i--;
                    }

                    if (bpp)
                    {
                        tableauTrie[0] = x;
                    }else
                    {
                        tableauTrie[i+1] = x;
                    }
                }
            }
        }
    }
}
