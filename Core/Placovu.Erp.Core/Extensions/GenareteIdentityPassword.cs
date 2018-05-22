using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placovu.Erp.Core.Extensions
{
    public static class IdentityExtensions
    {
        public static string GenareteIdentityPassword(this string value)
        {
            List<int> nonSelectedIndexes = new List<int>(Enumerable.Range(0, value.Length));
            Random rand = new Random();

            if (!value.Any(x => char.IsDigit(x)))
            { //does not contain digit
                char[] pass = value.ToCharArray();
                int pos = nonSelectedIndexes[rand.Next(nonSelectedIndexes.Count)];
                nonSelectedIndexes.Remove(pos);
                pass[pos] = Convert.ToChar(rand.Next(10) + '0');
                value = new string(pass);
            }

            if (!value.Any(x => char.IsLower(x)))
            { //does not contain lower
                char[] pass = value.ToCharArray();
                int pos = nonSelectedIndexes[rand.Next(nonSelectedIndexes.Count)];
                nonSelectedIndexes.Remove(pos);
                pass[pos] = Convert.ToChar(rand.Next(26) + 'a');
                value = new string(pass);
            }

            if (!value.Any(x => char.IsUpper(x)))
            { //does not contain upper
                char[] pass = value.ToCharArray();
                int pos = nonSelectedIndexes[rand.Next(nonSelectedIndexes.Count)];
                nonSelectedIndexes.Remove(pos);
                pass[pos] = Convert.ToChar(rand.Next(26) + 'A');
                value = new string(pass);
            }
            return value;
        }
    }
}
