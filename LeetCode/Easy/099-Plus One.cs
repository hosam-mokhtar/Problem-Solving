Link: https://leetcode.com/problems/plus-one/
Language: C#





public class Solution {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }
}