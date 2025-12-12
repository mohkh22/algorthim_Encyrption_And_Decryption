using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyrptionAndDecryption
{
    public static class PolyAlphabetic
    {
        public static string VgnEncyrption(string plaintext, string key)
        {
            var result = "";
            var text = key;
            if (key.Length != plaintext.Length)
            {
                var len = plaintext.Length - key.Length;
                int index = 0;
                for (int i = 0; i < len; i++)
                {
                    if (text.Length < plaintext.Length)
                    {
                        if (key.Length < len)
                        {
                            index = 0;
                        }
                        text += key[index];
                        index++;
                    }

                }
            }
            else
            {
                text = key;
            }

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < plaintext.Length; i++)
            {
                var p = plaintext[i];
                var k = text[i];
                if (char.IsLetter(p))
                {
                    var indexp = char.IsUpper(p) ? Array.IndexOf(Upper, p) : Array.IndexOf(letters, p);
                    var indexk = char.IsUpper(k) ? Array.IndexOf(Upper, k) : Array.IndexOf(letters, k);
                    var c = (indexp + indexk) % 26;
                    var offset = char.IsUpper(p) ? Upper[c] : letters[c];
                    result += offset;
                }
                else
                {
                    result += p;
                }

            }

            return result;
        }

        public static string VgnDecryption(string plaintext, string key)
        {
            var result = "";
            var text = key;
            if (key.Length != plaintext.Length)
            {
                var len = plaintext.Length - key.Length;
                int index = 0;
                for (int i = 0; i < len; i++)
                {
                    if (text.Length < plaintext.Length)
                    {
                        if (key.Length < len)
                        {
                            index = 0;
                        }
                        text += key[index];
                        index++;
                    }

                }
            }
            else
            {
                text = key;
            }

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < plaintext.Length; i++)
            {
                var p = plaintext[i];
                var k = text[i];
                if (char.IsLetter(p))
                {
                    var indexp = char.IsUpper(p) ? Array.IndexOf(Upper, p) : Array.IndexOf(letters, p);
                    var indexk = char.IsUpper(k) ? Array.IndexOf(Upper, k) : Array.IndexOf(letters, k);
                    var c = (indexp - indexk + 26) % 26;
                    var offset = char.IsUpper(p) ? Upper[c] : letters[c];
                    result += offset;
                }
                else
                {
                    result += p;
                }

            }

            return result;
        }


        public static string playEncyrption(string plaintext, string key)
        {
            var result = "";
            char[,] letters = new char[5, 5] ;
             char[] k = key.ToUpper().Replace("J", "I").ToCharArray();
            char[] alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
            int indexalpha = 0; 
            int indexkey = 0; 
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(indexkey <key.Length)
                    {
                        letters[i,j] = k[indexkey];
                        indexkey++;
                    }
                    else
                    {
                        if(k.Contains(alphabet[indexalpha]))
                        {
                            indexalpha++;
                            j--;
                        }
                        else
                        {
                            letters[i,j] = alphabet[indexalpha];
                            indexalpha++;
                        }
                    }
                }
            }


            for (int i = 0; i < plaintext.Length; i+=2)
            {
                if (plaintext[i] == plaintext[i+1])
                {
                   plaintext=  plaintext.Substring(0, i + 1) + 'X' + plaintext.Substring(i + 1);
                }
               
                    var ind1 = FindIndex(letters, plaintext[i]); 
                    var ind2 = FindIndex(letters, plaintext[i+1]);
                    if (ind1[0] == ind2[0])
                    {
                        result += letters[ind1[0], (ind1[1] + 1) % 5];
                        result += letters[ind2[0], (ind2[1] + 1) % 5];
                    }
                    else if (ind1[1] == ind2[1])
                    {
                        result += letters[ind1[0]+1, (ind1[1] ) % 5];
                        result += letters[ind2[0]+1, (ind2[1]) % 5];
                    }
                    else
                    {
                        int col = Math.Max(ind1[1], ind2[1]) - Math.Min(ind1[1], ind2[1]);
                        int max = Math.Max(ind1[1], ind2[1]);
                        if(max == ind1[1])
                        {
                            result += letters[ind1[0] , (ind1[1] - col) % 5];
                            result += letters[ind2[0], (ind2[1] + col) % 5];
                        }
                        else
                        {
                            result += letters[ind1[0] , (ind1[1] +col) % 5];
                            result += letters[ind2[0] , (ind2[1] - col) % 5];
                        }
                       
                    }
                

               
            }




            return result;
        }

        public static string playDecryption(string plaintext, string key)
        {
            var result = "";
            char[,] letters = new char[5, 5];
            char[] k = key.ToUpper().Replace("J", "I").ToCharArray();
            char[] alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
            int indexalpha = 0;
            int indexkey = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (indexkey < key.Length)
                    {
                        letters[i, j] = k[indexkey];
                        indexkey++;
                    }
                    else
                    {
                        if (k.Contains(alphabet[indexalpha]))
                        {
                            indexalpha++;
                            j--;
                        }
                        else
                        {
                            letters[i, j] = alphabet[indexalpha];
                            indexalpha++;
                        }
                    }
                }
            }

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                if (plaintext[i] == plaintext[i + 1])
                {
                    plaintext = plaintext.Substring(0, i + 1) + 'X' + plaintext.Substring(i + 1);
                    if(plaintext.Length % 2 != 0)
                    {
                        plaintext += 'X';
                    }
                }

                var ind1 = FindIndex(letters, plaintext[i]);
                var ind2 = FindIndex(letters, plaintext[i + 1]);
                if (ind1[0] == ind2[0])
                {
                    result += letters[ind1[0], (ind1[1] - 1) % 5];
                    result += letters[ind2[0], (ind2[1] - 1) % 5];
                }
                else if (ind1[1] == ind2[1])
                {
                    result += letters[ind1[0] - 1, (ind1[1]) % 5];
                    result += letters[ind2[0] - 1, (ind2[1]) % 5];
                }
                else
                {
                    int col = Math.Max(ind1[1], ind2[1]) - Math.Min(ind1[1], ind2[1]);
                    int max = Math.Max(ind1[1], ind2[1]);
                    if (max == ind1[1])
                    {
                        result += letters[ind1[0], (ind1[1] - col) % 5];
                        result += letters[ind2[0], (ind2[1] + col) % 5];
                    }
                    else
                    {
                        result += letters[ind1[0], (ind1[1] + col) % 5];
                        result += letters[ind2[0], (ind2[1] - col) % 5];
                    }

                }
            }
            for(int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] == 'X' && result[i - 1] == result[i + 1])
                {
                    result = result.Remove(i, 1);
                }
            }
            return result;
        }

        public static string AutoKeyEncyrption (string plaintext , string key )
        {
            var result = "";
            var text = key;
            if (key.Length != plaintext.Length)
            {
                var len = plaintext.Length - key.Length;
                int index = 0;
                for (int i = 0; i < len; i++)
                {
                    if (text.Length < plaintext.Length)
                    {
                        text += plaintext[index];
                        index++;
                    }
                }
            }
            else
            {
                text = key;
            }

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < plaintext.Length; i++)
            {
                var p = plaintext[i];
                var k = text[i];
                if (char.IsLetter(p))
                {
                    var indexp = char.IsUpper(p) ? Array.IndexOf(Upper, p) : Array.IndexOf(letters, p);
                    var indexk = char.IsUpper(k) ? Array.IndexOf(Upper, k) : Array.IndexOf(letters, k);
                    var c = (indexp + indexk) % 26;
                    var offset = char.IsUpper(p) ? Upper[c] : letters[c];
                    result += offset;
                }
                else
                {
                    result += p;
                }

            }
            return result; 
        }

        public static string AutoKeyDencyrption(string plaintext, string key)
        {
            var result = "";
            var text = key;
            //if (key.Length != plaintext.Length)
            //{
            //    var len = plaintext.Length - key.Length;
            //    int index = 0;
            //    for (int i = 0; i < len; i++)
            //    {
            //        if (text.Length < plaintext.Length)
            //        {
            //            text += plaintext[index];
            //            index++;
            //        }
            //    }
            //}
            //else
            //{
            //    text = key;
            //}

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < plaintext.Length; i++)
            {
                var p = plaintext[i];
                var k = text[i];
                if (char.IsLetter(p))
                {
                    var indexp = char.IsUpper(p) ? Array.IndexOf(Upper, p) : Array.IndexOf(letters, p);
                    var indexk = char.IsUpper(k) ? Array.IndexOf(Upper, k) : Array.IndexOf(letters, k);
                    var c = Math.Abs((indexp - indexk)) % 26;
                    var offset = char.IsUpper(p) ? Upper[c] : letters[c];
                    text += offset;
                    result += offset;
                }
                else
                {
                    result += p;
                }

            }
            return result;
        }



        public static int[] FindIndex(char[,] matrix, char ch)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == ch)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1,-1 };
        }
    }
}
