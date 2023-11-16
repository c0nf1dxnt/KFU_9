namespace Part1
{
    public class BCipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    char baseChar = char.IsUpper(result[i]) ? 'A' : 'a';
                    if (char.IsUpper(result[i]))
                    {
                        result[i] = (char)(baseChar + ('Z' - result[i]));
                    }
                    else
                    {
                        result[i] = (char)(baseChar + ('z' - result[i]));
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
                    char baseChar = char.IsUpper(result[i]) ? 'A' : 'a';
                    if (char.IsUpper(result[i]))
                    {
                        result[i] = (char)(baseChar + ('Z' - result[i]));
                    }
                    else
                    {
                        result[i] = (char)(baseChar + ('z' - result[i]));
                    }
                }
            }
            return new string(result);
        }
    }

}
