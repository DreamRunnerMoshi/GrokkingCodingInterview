public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = int.MinValue;
        
        for(int i=0; i< accounts.Length; i++) {
            int customerWealth = 0;
            
            for(int j=0; j< accounts[0].Length; j++) {
                customerWealth += accounts[i][j];
            }
            
            if(max<customerWealth) max = customerWealth;
        }
        
        return max;
    }
}