using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueEncryptionExample
{
    public class ValueEncryption
    {
        public struct EncryptedFloat
        {
            public float value;
            public int key;

            public float Decrypt()
            {
                return (value + key) * -1;
            }
        }


        static Random rnd = new Random();
        public static EncryptedFloat EncryptFloat(float value)
        {
            EncryptedFloat encryptedFloat;
            encryptedFloat.key = rnd.Next(100000, 1000000);
            encryptedFloat.value = (value + encryptedFloat.key) * -1;
            return encryptedFloat;
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Original Health: 100\n");

            ValueEncryption.EncryptedFloat encryptedHealth = ValueEncryption.EncryptFloat(100f);

            Console.WriteLine("EncryptedHealth: " + encryptedHealth.value);
            Console.WriteLine("DecryptedHealth: " + encryptedHealth.Decrypt());

            Console.ReadKey();
        }
    }
}
