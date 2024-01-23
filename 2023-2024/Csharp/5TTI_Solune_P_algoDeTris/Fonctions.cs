using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_Solune_P_algoDeTris
{
    public struct Fonctions
    {
        public void intuitif(double[] tableauTrie)
        {
            double echange;
            for (int i = 0; i < tableauTrie.Length - 1; i++)
            {
                for (int j = i + 1; j < tableauTrie.Length; j++)
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

        public void selection(double[] tableauTrie)
        {
            double replaceValue;
            int replaceIndex;
            for (int i = 0; i <= tableauTrie.Length - 2; i++)
            {
                replaceIndex = i;
                replaceValue = tableauTrie[i];
                for (int checkIndex = i + 1; checkIndex <= tableauTrie.Length - 1; checkIndex++)
                {
                    if (tableauTrie[checkIndex] < replaceValue)
                    {
                        replaceValue = tableauTrie[checkIndex];
                        replaceIndex = checkIndex;
                    }
                }
                if (replaceIndex != i)
                {
                    tableauTrie[replaceIndex] = tableauTrie[i];
                    tableauTrie[i] = replaceValue;
                }
            }
        }
        public string showTabInt(int[] tab)
        {
            string mess = "";
            for (int i = 0; i < tab.Length; i++)
            {
                mess += tab[i];
                mess += "; ";
            }
            return mess;
        }

        public void bulle(double[] tableauTrie)
        {
            bool b1 = true;
            double az;
            while (b1)
            {
                b1 = false;
                for (int i = 0; i < tableauTrie.Length - 1; i++)
                {
                    if (tableauTrie[i] > tableauTrie[i + 1])
                    {
                        az = tableauTrie[i];
                        tableauTrie[i] = tableauTrie[i + 1];
                        tableauTrie[i + 1] = az;
                        b1 = true;
                    }
                }
            }
        }

        public void shell(double[] tableauTrie)
        {
            int ecart = tableauTrie.Length;
            bool swp;
            double swap;
            do
            {
                ecart /= 2;
                do
                {
                    swp = false;
                    for (int i = 0; i < tableauTrie.Length - ecart; i++)
                    {
                        if (tableauTrie[i] > tableauTrie[i + ecart])
                        {
                            swp = true;
                            swap = tableauTrie[i];
                            tableauTrie[i] = tableauTrie[i + ecart];
                            tableauTrie[i + ecart] = swap;
                        }
                    }
                } while (swp);
            } while (ecart != 1);
        }

        public void encastrement(double[] tableauTrie)
        {
            int n = tableauTrie.Length;
            for (int j = 1; j < n; j++)
            {
                double x = tableauTrie[j];
                int i = j - 1;
                bool bpp = false;
                while (x < tableauTrie[i] && !bpp)
                {
                    tableauTrie[i + 1] = tableauTrie[i];
                    if (i == 0)
                    {
                        bpp = true;
                    }
                    else
                    {
                        i = i - 1;
                    }
                }
                if (bpp)
                {
                    tableauTrie[0] = x;
                }
                else
                {
                    tableauTrie[i + 1] = x;
                }
            }
        }
    }
}
