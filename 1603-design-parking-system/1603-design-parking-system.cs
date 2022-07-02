public class ParkingSystem {

    Dictionary<int, int> typeCountMap = new Dictionary<int, int>();
    
    public ParkingSystem(int big, int medium, int small) {
        typeCountMap[1] = big;
        typeCountMap[2] = medium;
        typeCountMap[3] = small;
    }
    
    public bool AddCar(int carType) {
        if(typeCountMap[carType]>0) {
            typeCountMap[carType]--;
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