namespace ChallengeProblemSolution.TwoPointer;

public class Solution001
{
    public bool IsPalindrome(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsSymbol(s[i]) 
                || char.IsWhiteSpace(s[i]) 
                || char.IsPunctuation(s[i]))
                continue;
            res += char.ToLower(s[i]);
        }

        int start = 0, end = res.Length - 1;
        while (start < end)
        {
           if (res[start] != res[end])
               return false;
           start++;
           end--;
        }    


        return true;
    }
}
