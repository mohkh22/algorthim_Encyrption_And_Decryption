using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyrptionAndDecryption
{
    public static class Monoalphabetic
    {
        public static string Encyrption (string plaintext)
        {
            string text = plaintext;
            string result = "";

            for(int i = 0; i<text.Length; i++)
            {
                var letter = text[i];

                var offset = char.IsUpper(letter) ? 'A' : 'a';

                if (char.IsLetter(letter))
                {
                    char c = (char)((letter -offset +3) % 26 + offset);
                    result += c;
                }
                else
                {
                    result += letter;
                }

            }
            return result;

        }

        public static string Decryption(string plaintext)
        {
            string text = plaintext;
            string result = "";
           
            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                var offset = char.IsUpper(letter)?'A':'a';
                if (char.IsLetter(letter))
                {
                    var c = (char)((letter - offset - 3) % 26 +offset);
                    result += c;
                }
                else
                {
                    result += letter;
                }

            }
            return result;
        }

    }
}
