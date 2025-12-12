using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    public class CaesarCipher
    {
        public int Shift { get; set; }

        public CaesarCipher(int shift)
        {
            Shift = shift;
        }

        public string Encrypt(string plaintext)
        {
            string result = "";
            foreach (char c in plaintext.ToUpper())
            {
                if (char.IsLetter(c))
                {
                    //char offset = 'A';
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)(((c - offset + Shift) % 26) + offset);
                }
                else
                    result += c;
            }
            return result;
        }

        public string Decrypt(string ciphertext)
        {
            string result = "";
            foreach (char c in ciphertext.ToUpper())
            {
                if (char.IsLetter(c))
                {
                    //char offset = 'A';
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    result += (char)(((c - offset - Shift + 26) % 26) + offset);
                }
                else
                    result += c;
            }
            return result;
        }
    }
}
