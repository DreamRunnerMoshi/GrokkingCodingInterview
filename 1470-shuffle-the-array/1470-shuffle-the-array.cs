public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        
        var newArray = new int [2*n];
        
        for(int i=0; i<n; i++) {
            newArray[i*2] = nums[i];
            newArray[i*2 + 1] = nums[n+i];
        }
        
        return newArray;
    }
}