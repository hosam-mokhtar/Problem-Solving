Link: https://leetcode.com/problems/truncate-sentence/
Language: C#



public class Solution {
public string TruncateSentence(string s, int k) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                k--;
                if (k == 0)
                return sb.ToString();
                else
                sb.Append(s[i]);

            }    
            return  sb.ToString();
        }
}