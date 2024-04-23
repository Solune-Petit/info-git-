using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_Solune_P_StockageAdressesIP
{
    public struct adresses
    {
        public string nom;
        public int[] IP;
        
        public adresses()
        {
            IP = new int[4];
        }
    }
}
