public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i =0; i<nums.Length; i++)
        {
            int complement = target - nums[i];

            if(map.ContainsKey(complement))
            {
                return new int[] {map[complement], i} ;
            }

            map[nums[i]] = i;

        }
        // for(int left=0; left < nums.Length; left++)
        // {
        //     int right = nums.Length-1;
        //     while(right >left)
        //     {
        //         if(nums[left] + nums[right] == target)
        //         {
        //             return new int[] {left,right};
        //         }
        //         else{
        //             right--;
        //         }
        //     }
        // }
        return null;

    }
}