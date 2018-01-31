﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Classes
{
    public class MakeOutWordClass
    {

        /*
         Given an "out" string length 4, such as "<<>>", and a word, return a new string where the word is in the 
         middle of the out string, e.g. "<<word>>". Note: use str.Substring(i, j) to extract the string starting 
         at index i and going up to but not including index j.
         makeOutWord("<<>>", "Yay") → "<<Yay>>"	
         makeOutWord("<<>>", "WooHoo") → "<<WooHoo>>"	
         makeOutWord("[[]]", "word") → "[[word]]"	
        */
        public string MakeOutWord(string output, string word)
        {
            if (output.Length == 0)
            {
                return word;
            }

            return output.Substring(0, 2) + word + output.Substring(2);
        }
    }
}