using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyrptionAndDecryption
{
    public static class OtherEnc_dec
    {
        public static rturnobject Encryption(string plain)
        {
            string result = "";
            string key = "";
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Random rnd = new Random();
            for (int i = 0; i <plain.Length; i++)
            {
                int index = rnd.Next(0, Upper.Length);
                key += Upper[index];
            }
            for(int i = 0; i <plain.Length; i++)
            {
                int p = Array.IndexOf(Upper,plain[i]);
                int indexkey = Array.IndexOf(Upper,key[i]);
                int c = (p + indexkey) % 26;
                result += Upper[c];
            }

            int k = Array.IndexOf(Upper,key[key.Length-1]) ;
            k = k == 0 ? 3 : k; 

            string enckey = "";

            for (int i = 0; i < key.Length-1 ; i++)
            {
                int indexk = Array.IndexOf(Upper, key[i]);
                indexk = (indexk + k) % 26;
                enckey += Upper[indexk];
            }

            enckey += key[key.Length - 1];

            return new rturnobject() {cipher = result , key=enckey };
        }

        public static string Decryption(string cipher, string key)
        {
            string result = "";
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int k = Array.IndexOf(Upper, key[key.Length - 1]);
            k = k == 0 ? 3 : k;
            string deckey = "";
            for(int i = 0; i < key.Length - 1; i++)
            {
                int indexk = Array.IndexOf(Upper, key[i]);
                indexk = (indexk - k + 26) % 26;
                deckey += Upper[indexk];
            }
            deckey += key[key.Length-1];


            for (int i = 0; i < cipher.Length; i++)
            {
                int c = Array.IndexOf(Upper, cipher[i]);
                int indexkey = Array.IndexOf(Upper, deckey[i]);
                int p = (c - indexkey + 26) % 26;
                result += Upper[p];
            }


            return result;
        }
    }




    public class rturnobject
    {
        public string cipher { get; set; }
        public string key { get; set; }
    }
}
