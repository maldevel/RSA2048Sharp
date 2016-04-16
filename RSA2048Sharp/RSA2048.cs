/*
RSA2048 - RSA 2048 encryption using CryptoAPI
Copyright (C) 2016  @maldevel

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Security.Cryptography;
using System.Text;

namespace RSA2048Sharp
{
    class RSA2048
    {
        public static void GenerateKeys(out string PublicKey, out string PrivateKey)
        {
            using (RSACryptoServiceProvider RSA2048 = new RSACryptoServiceProvider(2048))
            {
                PublicKey = RSA2048.ToXmlString(false);
                PrivateKey = RSA2048.ToXmlString(true);
            }
        }

        public static string Encrypt(string PublicKey, string plain)
        {
            using (RSACryptoServiceProvider RSA2048 = new RSACryptoServiceProvider(2048))
            {
                RSA2048.FromXmlString(PublicKey);
                return Convert.ToBase64String(RSA2048.Encrypt(Encoding.UTF8.GetBytes(plain), false));
            }
        }

        public static string Decrypt(string PrivateKey, string cipher)
        {
            using (RSACryptoServiceProvider RSA2048 = new RSACryptoServiceProvider(2048))
            {
                RSA2048.FromXmlString(PrivateKey);
                return Encoding.UTF8.GetString(RSA2048.Decrypt(Convert.FromBase64String(cipher), false));
            }
        }
    }
}
