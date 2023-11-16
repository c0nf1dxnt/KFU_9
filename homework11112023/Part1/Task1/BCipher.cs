using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class BCipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = input.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char baseChar = char.IsLower(result[i]) ? 'a' : 'A';
                    result[i] = (char)(baseChar + ('z' - result[i] + baseChar));
                }
            }
            return new string(result);
        }
        public string Decode(string input)
        {
            char[] result = input.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char baseChar = char.IsLower(result[i]) ? 'a' : 'A';
                    result[i] = (char)(baseChar + ('z' - result[i] + baseChar));
                }
            }
            return new string(result);
        }
    }
}
