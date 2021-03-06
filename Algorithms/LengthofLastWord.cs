// Source : https://leetcode.com/problems/length-of-last-word/ 
// Author : codeyu 
// Date : Saturday, December 10, 2016 10:32:12 PM 

/**********************************************************************************
*
* Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
* 
* If the last word does not exist, return 0.
* 
* Note: A word is defined as a character sequence consists of non-space characters only.
* 
* 
* For example, 
* Given s = "Hello World",
* return 5.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution058 
    {
        public static int LengthOfLastWord(string s) 
        {
            if(string.IsNullOrWhiteSpace(s)) return 0;
            var words = s.Trim().Split(' ');
            var lastWordIndex = words.Length - 1;
            return words[lastWordIndex].Length;
        }
    }
}

