using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionAndDecryption
{
    public static class CaesarCipher
    {
        public static string Encyrption(string text , int key)
        {
            var enctext= string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                var letter = text[i];
                if (char.IsLetter(letter))
                {
                    var offset = char.IsUpper(letter)?'A':'a';
                    var encletter = (char)((letter + key - offset)%26 +offset);
                    enctext += encletter; 
                }
                else
                {
                    enctext += letter;
                }
            }
            return enctext;
        }


        public static string Decryption(string text, int key)
        {
            var dectext = string.Empty;

            for (int j = 0; j < text.Length; j++)
            {
                var letter = text[j];
                if (char.IsLetter(letter))
                {
                    var offset = char.IsUpper(letter) ? 'A' : 'a';
                    var decletter = (char)((letter - key - offset + 26) %26 + offset); 
                    dectext += decletter;
                }
                else
                {
                    dectext += letter;
                }
            }
            return dectext;
        }



    }
}
