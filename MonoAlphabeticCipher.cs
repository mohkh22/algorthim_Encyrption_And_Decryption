using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    public class MonoAlphabeticCipher
    {
        private string key; //QWERTYUIOPASDFGHJKLZXCVBNM
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public MonoAlphabeticCipher(string key)
        {
            
            this.key = key.ToUpper();
        }

        public string Encrypt(string plaintext)
        {
            plaintext = plaintext.ToUpper();
            string result = "";

            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    int index = alphabet.IndexOf(c);
                    result += key[index];
                }
                else
                {
                    result += c; 
                }
            }
            return result;
        }

        public string Decrypt(string ciphertext)
        {
            ciphertext = ciphertext.ToUpper();
            string result = "";

            foreach (char c in ciphertext)
            {
                if (char.IsLetter(c))
                {
                    int index = key.IndexOf(c);
                    result += alphabet[index];
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
    }
}

