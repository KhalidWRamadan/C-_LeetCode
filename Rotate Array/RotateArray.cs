public class RotateArray
{
    public void Rotate(int[] nums, int k)
    {
        int[] rotatedArray = new int[nums.Length];
        k = k % nums.Length;

        for (int i = 0; i < nums.Length; i++) rotatedArray[(i + k) % nums.Length] = nums[i];
        for (int i = 0; i < nums.Length; i++) nums[i] = rotatedArray[i];
    }
}