public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var dictionary = new Dictionary<int, int>();
        var numberOfPairs = 0;
        
        for(int i=0; i<nums.Length; i++) {
            if(!dictionary.ContainsKey(nums[i])){
                dictionary.Add(nums[i],0);     
            }
            dictionary[nums[i]]++;
        }
        
        foreach(var key in dictionary.Keys){
            var freq = dictionary[key];
            numberOfPairs+= (freq*(freq-1))/2;
        }
        
        return numberOfPairs;
    }
}