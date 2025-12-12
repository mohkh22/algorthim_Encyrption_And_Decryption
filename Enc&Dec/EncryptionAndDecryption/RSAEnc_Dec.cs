using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncyrptionAndDecryption
{
    public static  class RSAEnc_Dec
    {
        public static RSARESULT Encryption(string plaintext , string pp =null ,string qq =null , string ee=null )
        {
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = "";
            int p =0, q=0, e=0;
            int n = 0 ; 
            int eular = 0;
            Random rand = new Random();

            if (string.IsNullOrEmpty(pp) && string.IsNullOrEmpty(qq))
            {
                while(true)
                {

                    if(IsPrime(p) && IsPrime(q))
                    {
                        break; 
                    }
                    if (IsPrime(p) == false)
                    {
                        p = rand.Next(0, 26);
                    }
                    if (IsPrime(q) == false)
                    {
                        q= rand.Next(0, 26);
                    }
                }
            }
            else
            {
                p = int.Parse(pp);
                q = int.Parse(qq);
            }
            
            n = p * q; 
            eular = (p - 1) * (q - 1);

            if (string.IsNullOrEmpty(ee))
            {
                while (true)
                {
                    e = rand.Next(2, eular);
                    if (e> 1 && e < eular && GCD(e, eular))
                    {
                        break;
                    }
                }
            }
            else
            {
                e = int.Parse(ee);
            }

               
            for(int i = 0; i < plaintext.Length; i++)
            {
                double m =  Math.Pow(Array.IndexOf(Upper, plaintext[i]), e)  % n;
                int x = Convert.ToInt32(m) %26; 
                result += Upper[x]; 
            }

            var obj = new RSARESULT() { p = p, q = q, e = e, result = result };
            return obj;  
        }

        public static string Decryption(string plaintext, int p, int q, int e)
        {
            string result = "";
            char[] Upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int n = p * q;
            int eular = (p - 1) * (q - 1);
            int d = 0;

            for (int i = 0; i < 26; i++)
            {
                if ((e * i) % 26 == 1)
                {
                    d = i;
                }
            }


            for (int i = 0; i < plaintext.Length; i++)
            {
                double c = Math.Pow(Array.IndexOf(Upper, plaintext[i])  , d) % n;
                int x = Convert.ToInt32(c) ;
                result += Upper[x];
            }


            return result;
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    
        public static bool GCD(int a, int b)
        {
             for( int i = 2; i<= a; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return false;
                }
            }

            return true;
        }



    }

    public class RSARESULT
    {
        public string result { get; set; }
        public int p { get; set; }
        public int q { get; set; }
        public int e { get; set; }
    }


}
