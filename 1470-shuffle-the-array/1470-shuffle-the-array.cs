public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        var l = nums.Length;
        var mid = l/2;
        
        var newArray = new int [2*n];
        
        for(int i=0; i<mid; i++) {
            newArray[i*2] = nums[i];
        }
        
         for(int i=1; i<=mid; i++) {
            newArray[i*2 - 1] = nums[mid+i-1];
        }
        
        return newArray;
    }
}