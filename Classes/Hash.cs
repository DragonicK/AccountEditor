using System;
using System.Text;
using System.Security.Cryptography;

namespace AccountEditor {
    public static class Hash {
        static MD5 md5 = new MD5CryptoServiceProvider();

        public static string GetPassword(string username, string password) {
            var salt = GetHash(username);
            var computed = GetHash(password);
            return GetHash(GetHash(salt) + computed);
        }

        public static string GetHash(string text) {
            var bytes = Encoding.ASCII.GetBytes(text);
            var computed = md5.ComputeHash(bytes);
            return BitConverter.ToString(computed).Replace("-", "").ToLower();
        }
    }
}