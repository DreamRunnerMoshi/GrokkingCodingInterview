public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int [] nextGreater = new int [nums1.Length];
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        for(int i=0; i<nums2.Length; i++){
            map.Add(nums2[i], i);
        }
        
        for(int i=0; i<nums1.Length; i++)
        {
            nextGreater[i] = findNextGreater(nums2, nums1[i], map[nums1[i]]);
        }
        
        return nextGreater;
    }
    
    private int findNextGreater(int [] nums2, int number, int startIndex){
        
        for(int i = startIndex; i< nums2.Length; i++){
            if(nums2[i] > number) return nums2[i];    
        }
        
        return -1;
    }
}