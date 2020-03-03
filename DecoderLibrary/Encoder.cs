using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Runtime.Security;

namespace DecoderLibrary
{
    public static class Encoder
    {
        public static string Encrypt(string connectionString)
        {
            try
            {
                var result = SimpleStringCipher.Instance.Encrypt(connectionString);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string Decrypt(string connectionString)
        {
            try
            {
                var result = SimpleStringCipher.Instance.Decrypt(connectionString);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
