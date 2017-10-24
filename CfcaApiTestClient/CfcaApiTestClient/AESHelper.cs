// ***********************************************************************
// Assembly         : CfcaApiTestClient
// Author           : Walter Wang
// Created          : 2017-10-24
//
// Last Modified By : Walter Wang
// Last Modified On : 2017-10-24
// ***********************************************************************
// <copyright file="AESHelper.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CfcaApiTestClient
{
    /// <summary>
    /// Class AESHelper.
    /// </summary>
    public static class AESHelper
    {
        /// <summary>
        /// Decrypts the string from bytes aes.
        /// </summary>
        /// <param name="cipherText">The cipher text.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The iv.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">cipherText
        /// or
        /// Key
        /// or
        /// IV</exception>
        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an AesCryptoServiceProvider object
            // with the specified key and IV.
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;
        }

        /// <summary>
        /// Decrypts the string from bytes aes.
        /// </summary>
        /// <param name="cipherText">The cipher text.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The iv.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">Key
        /// or
        /// IV</exception>
        public static string DecryptStringFromBytes_Aes(byte[] cipherText, string Key, string IV)
        {
            if (string.IsNullOrEmpty(Key))
                throw new ArgumentNullException("Key");
            if (string.IsNullOrEmpty(IV))
                throw new ArgumentNullException("IV");

            byte[] keyByteArry = Encoding.UTF8.GetBytes(Key);
            byte[] ivByteArry = Encoding.UTF8.GetBytes(IV);

            return DecryptStringFromBytes_Aes(cipherText, keyByteArry, ivByteArry);
        }

        /// <summary>
        /// Encrypts the string to bytes aes.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The iv.</param>
        /// <returns>System.Byte[].</returns>
        /// <exception cref="ArgumentNullException">plainText
        /// or
        /// Key
        /// or
        /// IV</exception>
        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an AesCryptoServiceProvider object
            // with the specified key and IV.
            using (AesCryptoServiceProvider aesAlg = new AesCryptoServiceProvider())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }


        /// <summary>
        /// Encrypts the string to base64 aes.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The iv.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentNullException">Key
        /// or
        /// IV</exception>
        public static string EncryptStringToBase64_Aes(string plainText, string Key, string IV)
        {
            if (string.IsNullOrEmpty(Key))
                throw new ArgumentNullException("Key");
            if (string.IsNullOrEmpty(IV))
                throw new ArgumentNullException("IV");

            byte[] keyByteArry = Encoding.UTF8.GetBytes(Key);
            byte[] ivByteArry = Encoding.UTF8.GetBytes(IV);

            return Convert.ToBase64String(EncryptStringToBytes_Aes(plainText, keyByteArry, ivByteArry));
        }
    }
}
