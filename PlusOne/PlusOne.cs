public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int leadingDigit = digits.Length - 1;
        if (digits[leadingDigit] != 9)
        {
            digits[leadingDigit]++;
            return digits;
        }
        else
        {
            int i = leadingDigit;
            while (digits[i] == 9)
            {
                digits[i] = 0;
                if (i == 0)
                {
                    int[] newArr = new int[digits.Length + 1];
                    newArr[0] = 1;
                    return newArr;
                }
                i--;
            }
            digits[i]++;
            return digits;
        }
    }
}