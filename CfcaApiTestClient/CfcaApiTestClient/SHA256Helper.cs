// ***********************************************************************
// Assembly         : CfcaApiTestClient
// Author           : Walter Wang
// Created          : 2017-10-24
//
// Last Modified By : Walter Wang
// Last Modified On : 2017-10-24
// ***********************************************************************
// <copyright file="SHA256Helper.cs" company="">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Security.Cryptography;
using System.Text;

namespace CfcaApiTestClient
{
    /// <summary>
    /// Class SHA256Helper.
    /// </summary>
    public static class SHA256Helper
    {
        /// <summary>
        /// Gets the sh a256 hash from string.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="Exception">GetSHA256HashFromString() fail,error:" + ex.Message</exception>
        public static string GetSHA256HashFromString(string plainText)
        {
            byte[] bytValue = Encoding.UTF8.GetBytes(plainText);
            try
            {
                SHA256 sha256 = new SHA256CryptoServiceProvider();
                byte[] retVal = sha256.ComputeHash(bytValue);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < retVal.Length; i++)
                {
                    sb.Append(retVal[i].ToString("X2"));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("GetSHA256HashFromString() fail,error:" + ex.Message);
            }
        }
    }
}
