using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = input.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    result[i] = (char)(result[i] + 1);
                    if ((char.IsLower(input[i]) && result[i] > 'z') || (char.IsUpper(input[i]) && result[i] > 'Z'))
                    {
                        result[i] = (char)(result[i] - 26);
                    }
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
                    result[i] = (char)(result[i] - 1);
                    if ((char.IsLower(input[i]) && result[i] < 'a') || (char.IsUpper(input[i]) && result[i] < 'A'))
                    {
                        result[i] = (char)((result[i] + 26));
                    }
                }
            }
            return new string(result);
        }
    }
}
