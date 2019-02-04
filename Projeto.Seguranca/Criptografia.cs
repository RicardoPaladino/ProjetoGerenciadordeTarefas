using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography; //criptografia..

namespace Projeto.Seguranca
{
    public class Criptografia
    {
        //método para encriptar em MD5
        public string EncriptarParaMD5(string valor)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            return BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty);
        }

        //método para encriptar em SHA1
        public string EncriptarParaSHA1(string valor)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(valor))).Replace("-", string.Empty);
        }
    }
}
