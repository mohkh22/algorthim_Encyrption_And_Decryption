using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyrptionAndDecryption
{
    public static  class Hillenc_dec
    {
        public static string Encyrption(string plaintext, string key)
        {
            int n = 0; 
            if (plaintext.Length % 2 == 0 && plaintext.Length !=2)
            {
                n = plaintext.Length / 2;
            }
            else
            {
                n = plaintext.Length;
            }
            string result = "";
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[,]matrixk = new int[n, n];
            int[,]matrixp = new int[n, 1];
            int ind = 0; 
            for(int i = 0; i <n; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    matrixk[i,j] = char.IsUpper(key[ind]) ? Upper.ToList().IndexOf(key[ind]) : letters.ToList().IndexOf(key[ind]);
                    ind++;
                }
            }
            for(int i = 0; i<n ; i++)
            {
                matrixp[i,0] = char.IsUpper(plaintext[i]) ? Upper.ToList().IndexOf(plaintext[i]) : letters.ToList().IndexOf(plaintext[i]);
            }
            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrixk[i, j] * matrixp[j, 0];
                }
               sum = sum % 26;
                result += Upper[sum];
            }
            return result;
        }

        public static string Dencyrption(string plaintext, string key)
        {
            string result = "";
            int n = 0;
            if (plaintext.Length % 2 == 0 && plaintext.Length != 2)
            {
                n = plaintext.Length / 2;
            }
            else
            {
                n = plaintext.Length;
            }
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[,] matrixk = new int[n, n];
            int[,] matrixp = new int[n, 1];
            int ind = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixk[i, j] = char.IsUpper(key[ind]) ? Upper.ToList().IndexOf(key[ind]) : letters.ToList().IndexOf(key[ind]);
                    ind++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                matrixp[i, 0] = char.IsUpper(plaintext[i]) ? Upper.ToList().IndexOf(plaintext[i]) : letters.ToList().IndexOf(plaintext[i]);
            }

            int det = 0;
            for (int i = 0; i < n; i++)
            {
                    det += (matrixk[0, i] * (matrixk[1, (i + 1) % n] * matrixk[2, (i + 2) % n]  - matrixk[1, (i + 2) % n] * matrixk[2, (i + 1) % n]));
            }
            det = det % 26;
            int detinv = 0; 

            for(int i = 0; i<26; i++)
            {
                if ((det * i) % 26 == 1)
                {
                    detinv = i;
                }
            }

            int[,] matrixinv = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixinv[i, j] = ((matrixk[(j + 1) % n, (i + 1) % n] * matrixk[(j + 2) % n, (i + 2) % n]) - (matrixk[(j + 1) % n, (i + 2) % n] * matrixk[(j + 2) % n, (i + 1) % n]));
                    matrixinv[i, j] = matrixinv[i, j] % 26;
                    if (matrixinv[i, j] < 0)
                    {
                        matrixinv[i, j] += 26;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += detinv * matrixinv[i, j] * matrixp[j, 0];
                }
                sum = sum % 26;
                result += Upper[sum];
            }



            return result;
        }
    }
}
