using System;
using System.Text;

namespace EncryptStrings.Classes
{
    internal static class DecryptionHelper
    {
        /// <summary>
        /// Method for decrypt string with Base64.
        /// </summary>
        /// <param name="dataEnc">Input encode string</param>
        /// <returns>Plain string</returns>
        public static string Decrypt_Base64(string dataEnc)
        {
            try
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(dataEnc));
            }

            catch (Exception)
            {
                return null;
            }
        }
    }
}
