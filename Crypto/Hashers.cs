using System.Text;
using System.Linq;
using System.Security.Cryptography;


namespace RickUtils.Cryptography
{
    public static class Hashers
    {
        public static string ToMD5(string input)
        {
            using(var md5 = MD5.Create())
            {
                byte[] @in = Encoding.ASCII.GetBytes(input);
                byte[] @out = md5.ComputeHash(@in);
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < @out.Length; i++)
                {
                    sb.Append(@out[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}