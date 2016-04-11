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

namespace RSA2048Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string publicKey;
            string privateKey;
            RSA2048.GenerateKeys(out publicKey, out privateKey);

            string plain = "testing";
            string encrypted = RSA2048.Encrypt(publicKey, plain);
            string decrypted = RSA2048.Decrypt(privateKey, encrypted);

            Console.WriteLine("Encrypted text: " + encrypted);
            Console.WriteLine("Decrypted text: " + decrypted);
        }
    }
}
