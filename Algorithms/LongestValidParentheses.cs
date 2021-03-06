// Source : https://leetcode.com/problems/longest-valid-parentheses/ 
// Author : codeyu 
// Date : Saturday, October 15, 2016 11:24:32 AM 

/**********************************************************************************
*
* Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
* 
* 
* For "(()", the longest valid parentheses substring is "()", which has length = 2.
* 
* 
* Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution032 {
        public static int LongestValidParentheses(string s) 
        {
            if(s.Length == 0) return 0;
            var result = 0;
            var dp = new List<int>{ 0 };
            for(var i=1; i<=s.Length; i++)
            {
                dp.Add(0);
                int j = i - 2 - dp[i-1];
                if(s[i-1] == '(' || j < 0 || s[j] == ')')
                {
                    dp[i] = 0;
                }
                else
                {
                    dp[i] = dp[i-1]+2+dp[j];
                    result = Math.Max(result, dp[i]);
                }
            }
            return result;
        }
    }
}

