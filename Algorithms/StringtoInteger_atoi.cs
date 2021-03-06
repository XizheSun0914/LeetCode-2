// Source : https://leetcode.com/problems/string-to-integer-atoi/ 
// Author : codeyu 
// Date : 2016/9/28 

/***************************************************************************************
*
* Implement atoi to convert a string to an integer.
* Hint: Carefully consider all possible input cases. If you want a strallenge, please do not see below and ask yourself what are the possible input cases.
* Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front. 
* Update (2015-02-10):
* The signature of the C++ function had been updated. If you still see your function signature accepts a const strar * argument, please click the reload button to reset your code definition. 
* Requirements for atoi: 
* The function first discards as many whitespace straracters as necessary until the first non-whitespace straracter is found. Then, starting from this straracter, takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
* The string can contain additional straracters after those that form the integral number, whistr are ignored and have no effect on the behavior of this function.
* If the first sequence of non-whitespace straracters in str is not a valid integral number, or if no sustr sequence exists because either str is empty or it contains only whitespace straracters, no conversion is performed.
* If no valid conversion could be performed, a zero value is returned. If the correct value is out of the range of representable values, INT_MAX (2147483647) or INT_MIN (-2147483648) is returned. 
*
**********************************************************************************/

namespace Algorithms
{
    public class Solution008
    {
        public static int MyAtoi(string str) 
        {
            if(str.Length == 0)
            {
                return 0;
            } 
            int i = 0;
            int returnNumber = 0;
            bool isNegative = false;
            int startPoint = 0;
            str = str.Trim();
            if ( str[0] == '-' )
            {
                isNegative = true;
                startPoint = 1;
            }
            if ( str[0] == '+' )
            {
                startPoint = 1;
            }
            str = str.Trim();
            for ( i = startPoint; i < str.Length; i++ )
            {
                if (str[i] >= '0'  && str[i] <= '9' && str[i] != ' ')
                {
                    if(!isNegative)
                    {
                        if(returnNumber > int.MaxValue / 10 || (returnNumber == int.MaxValue / 10 && (str[i] > '7')))
                        {
                            return int.MaxValue;
                        }
                    }
                    else
                    {
                        if(returnNumber > int.MaxValue / 10 || (returnNumber == int.MaxValue / 10 && (str[i] > '8')))
                        {
                            return int.MinValue;
                        }
                    }
                    returnNumber = returnNumber * 10 + (str[i] - '0');
                }    
                else
                {
                    break;
                }
            }
            return isNegative ? (-1 * returnNumber) : returnNumber;
        }
    }
}

