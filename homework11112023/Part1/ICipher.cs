﻿namespace Part1
{
    public interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
}