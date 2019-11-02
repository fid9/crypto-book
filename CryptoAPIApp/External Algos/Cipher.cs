using System;

namespace CryptoAPIApp
{
    class Cipher
    {
        public static string Encrypt(string textToEncrypt, int key)
        {
            if (textToEncrypt.Length == 0) return String.Empty;

            char chr = textToEncrypt[0].ToString().ToLower()[0];

            var code = IsBasicLetter(chr) ? (char)(((chr - 'a' + key) % 26) + 'a') : chr;
            return code + Encrypt(textToEncrypt.Substring(1), key);
        }

        public static string Decrypt(string textToDecrypt, int key)
        {
            if (textToDecrypt.Length == 0) return String.Empty;

            char chr = textToDecrypt[0].ToString().ToLower()[0];

            var code = IsBasicLetter(chr) ? (char)('z' - (('z' - chr + key) % 26)) : chr;
            return code + Decrypt(textToDecrypt.Substring(1), key);
        }

        private static bool IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
    }
}