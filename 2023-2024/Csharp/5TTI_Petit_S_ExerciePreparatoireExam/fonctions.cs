using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_Petit_S_ExerciePreparatoireExam
{
    internal class fonctions
    {

        
        public string control(string message, string cle)
        {
            string msgSSesp = RetireEspaces(message);
            CreeMat(msgSSesp, cle, out char[,] matrice);
            EcritChainesDansMatrice(ref matrice, cle, msgSSesp);
            CreeMatriceOutil(cle, out char[,] matriceOutils);
            ReporteOrder(matrice, matriceOutils);
            construitCryptage(matrice, out string msgCrypte);
            return msgCrypte;
        }
        
        
        static string RetireEspaces(string chaine)
        {
            string chaineSSEsp = "";
            int IG = chaine.Length;
            for (int i = 0; i < IG; i++)
            {
                if (chaine[i] != ' ')
                {
                    chaineSSEsp += chaine[i];
                }
            }

            return chaineSSEsp;
        }

        static void CreeMat(string text, string cle, out char[,] matrice)
        {
            int dim1 = (text.Length / cle.Length) + 2;
            int dim2 = cle.Length;

            if (text.Length % cle.Length != 0)
            {
                dim1++;
            }
            matrice = new char[dim1, dim2];
        }

        static void EcritChainesDansMatrice(ref char[,] matrice, string cle, string texte)
        {
            for (int i = 0;i <= matrice.GetLength(1) -1; i++)
            {
                matrice[0, i] = cle[i];
            }

            int k = 0;

            for (int i = 2; i <= matrice.GetLength(0) - 1; i++)
            {
                int j = 0;
                while (j < matrice.GetLength(1) && k < texte.Length)
                {
                    matrice[i, j] = texte[k];
                    k = k + 1;
                    j = j + 1;
                }
            }
        }

        static void triLigne1(ref char[,] matrice)
        {
            bool permut;
            char x;
            do
            {
                permut = false;

                for (int i = 0; i <= matrice.GetLength(1) - 2;i++)
                {
                    if (matrice[0,i] > matrice[0, i + 1])
                    {
                        x = matrice[0,i];
                        matrice[0,i] = matrice[0,i+1];
                        matrice[0,i+1] = x;
                        permut = true;
                    }
                }

            } while (permut == true);
        }


        static void CreeMatriceOutil(string cle, out char[,] matriceTriee)
        {
            matriceTriee = new char[3, cle.Length];
            for (int i = 0;i <= matriceTriee.GetLength(1) -1; i++)
            {
                matriceTriee[0,i] = cle[i];
                matriceTriee[2, i] = '0';
            }
            triLigne1(ref matriceTriee);
            for (int i = 1;i <= matriceTriee.GetLength(1); i++)
            {
                matriceTriee[1, i - 1] = char.Parse(i.ToString());
            }
        }

        static void ReporteOrder(char[,] matrice, char[,] matriceOutils)
        {
            bool trouve;
            int j;
            for (int i = 0; i <= matrice.GetLength(1) - 1; i++)
            {
                trouve = false;
                j = 0;
                while (!trouve &&  j < matriceOutils.GetLength(1))
                {
                    if (matrice[0,i] == matriceOutils[0,j] && matriceOutils[2,j] != '1')
                    {
                        matrice[1, i] = matriceOutils[1, j];
                        matriceOutils[2, j] = '1';
                        trouve = true;
                    }
                    j++;
                }
            }
            
        }

        static void construitCryptage(char[,] matrice, out string chaineCrypt)
        {
            bool trouve;
            int j;
            int i = 1;
            chaineCrypt = "";
            while (i<= matrice.GetLength(1))
            {
                trouve = false;
                j = 0;
                while(!trouve &&j < matrice.GetLength(1))
                {
                    if (char.Parse(i.ToString()) == matrice[1, j])
                    {
                        for (int k = 2; k <= matrice.GetLength(0) - 1; k++)
                        {
                            chaineCrypt += matrice[k,j];
                        }
                        chaineCrypt += ' ';
                        trouve = true;
                        i++;
                    }
                    j++;
                }
            }
            
        }


    }
}
