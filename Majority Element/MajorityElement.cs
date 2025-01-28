public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int numChecker = nums[0];
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == numChecker)
                count++;
            else
            {
                count--;
                if (count == 0)
                {
                    numChecker = nums[i];
                    count++;
                }
            }
        }
        return numChecker;
    }
}