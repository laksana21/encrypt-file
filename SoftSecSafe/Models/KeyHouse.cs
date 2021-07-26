using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SoftSecSafe.Models
{
    class KeyHouse
    {
        private string AddKey = "a8b7d0eb0112d3c55744c9074008e2b4";
        private int SecretKey = 173;

        public string GetAddressKey()
        {
            return AddKey;
        }

        public int GetSecretKey()
        {
            return SecretKey;
        }

        public string HashGenerator(string input)
        {
            MD5 strMd = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = strMd.ComputeHash(inputBytes);

            // Step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public int randomGenerator(int seed, int a, int b)
        {
            int result = (a * seed + b) & 255;
            return result;
        }
    }

    public class SafeMode
    {
        public string MetaKey { get; set; }
        public string Main { get; set; }
        public List<string> FileList { get; set; }
        public List<byte[]> DataList { get; set; }
        public int Seed { get; set; }
    }
}
