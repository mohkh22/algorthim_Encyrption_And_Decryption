using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyrptionAndDecryption
{
    public static  class AffineEnc_dec
    {

        public static string Encyrption (string plaintext ,int a , int b)
        {
            string result = "";
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for(int i = 0; i<plaintext.Length; i++)
            {
                int index = Char.IsUpper(plaintext[i]) ? Array.IndexOf(Upper, plaintext[i]) : Array.IndexOf(letters, plaintext[i]);  
                if (index != -1)
                {
                    int enc = (a * index + b) % 26;
                    result += Char.IsUpper(plaintext[i])? Upper[enc]: letters[enc];
                }
            }

            return result;
        }

        public static string Dencyrption(string plaintext, int a, int b)
        {
            string result = "";
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int inv = 0; 
            int flag = 0;

            for(var i = 0; i< 26; i++)
            {
                flag = (a * i) % 26;
                if (flag == 1)
                {
                    inv = i;
                }
            }


            for (int i = 0; i < plaintext.Length; i++)
            {
               
                int index = Char.IsUpper(plaintext[i]) ? Array.IndexOf(Upper, plaintext[i]) : Array.IndexOf(letters, plaintext[i]);
                if (index != -1)
                {
                    int enc = inv * (index - b +26) % 26  ;
                    result += Char.IsUpper(plaintext[i]) ? Upper[enc] : letters[enc];
                }
            }
            return result;
        }

    }
}
