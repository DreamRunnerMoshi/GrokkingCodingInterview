public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var set = new Dictionary<int, int>();
        
        for(int i=0;i<nums.Length; i++){
            var rest = target - nums[i];
            if(!set.ContainsKey(rest)){
                set.Add(rest, i);
            }
        }
            
         for(int i=0;i<nums.Length; i++){
            if(set.ContainsKey(nums[i])){
                if(set[nums[i]] != i)
                return new [] {i, set[nums[i]]};
            }
         }
        
        return new int [0];
    }
}