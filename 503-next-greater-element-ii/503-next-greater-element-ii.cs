public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        var stack = new Stack<int>();
        var length = nums.Length;
        
        var nextGreater = new int [length];
        nums = nums.Concat(nums).ToArray();
        stack.Push(0);
        
        for(int i=1; i<(length*2); i++){
            
            while(stack.Count()> 0 && nums[stack.Peek()] < nums[i]) {
                int index = stack.Pop();
                nextGreater[index] = nums[i];
            }
            if(i<length)
                stack.Push(i);
        }
        
        
        while(stack.Count()>0){
             nextGreater[stack.Pop()] =-1;
        }
        return nextGreater;
    }
}