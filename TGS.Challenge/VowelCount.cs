using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {   
          List<Char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
          return value.ToLower().Count(x => vowels.Contains(x));
        }
    }
}
