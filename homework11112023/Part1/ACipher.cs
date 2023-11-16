using System;

namespace Part1
{
    class ACipher : ICipher
    {
        public string Encode(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    if (text.ToLower()[i] == 'я')
                    {
                        result += Char.IsUpper(text[i]) ? 'А' : 'а';
                    }
                    else if (text.ToLower()[i] == 'z')
                    {
                        result += Char.IsUpper(text[i]) ? 'A' : 'a';
                    }
                    else
                    {
                        result += (char)(text[i] + 1);
                    }
                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }
        public string Decode(string text)
        {
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    if (text.ToLower()[i] == 'a')
                    {
                        result += Char.IsUpper(text[i]) ? 'Z' : 'z';
                    }
                    else if (text.ToLower()[i] == 'а')
                    {
                        result += Char.IsUpper(text[i]) ? 'Я' : 'я';
                    }
                    else
                    {
                        result += (char)(text[i] - 1);
                    }
                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }
    }
}
