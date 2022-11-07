using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncrypterCeasar
{
    internal class Encrypter
    {
        //There is not accounted for uppercae or special characters
        static public string Encrypt(string secret, string numberInput)
        {
            char[] encrytionTable = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'x', 'y', 'z', 'æ', 'ø', 'å', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string encryptedSecret ="";
            string errorMessage = "the number was not a number";
            int secretNumber;
            bool success = int.TryParse(numberInput, out secretNumber);

            if (success)
            {
                for (int i = 0; i < secret.Length; i++)
                {
                    int index = Array.IndexOf(encrytionTable, secret[i]);
                   encryptedSecret += encrytionTable[index + secretNumber];
                }
            }
            else
            {
                return errorMessage;
            }

            return encryptedSecret;
        }


    }
}
