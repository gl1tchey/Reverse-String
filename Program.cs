using System;

public class ReverseString
{
    public static void ReverseCharArray(char[] s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }
    }

    public static void Main(string[] args)
    {
        char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
        ReverseCharArray(s1);
    }
}
