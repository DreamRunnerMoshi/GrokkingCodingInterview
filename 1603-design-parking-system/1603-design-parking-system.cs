public class ParkingSystem {

    int [] typeCountMap = new int [3];
    
    public ParkingSystem(int big, int medium, int small) {
        typeCountMap[0] = big;
        typeCountMap[1] = medium;
        typeCountMap[2] = small;
    }
    
    public bool AddCar(int carType) {
        
        if(typeCountMap[carType - 1]>0) {
            typeCountMap[carType-1]--;
            return true;
        }
        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */