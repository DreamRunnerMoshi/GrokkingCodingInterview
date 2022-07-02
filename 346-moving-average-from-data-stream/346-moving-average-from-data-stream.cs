public class MovingAverage {

    Queue<int> q = new Queue<int>();
    int size = 0;
    double sum = 0.0;
    
    public MovingAverage(int size) {
        this.size = size;
    }
    
    public double Next(int val) {
        
        sum+=val;
        q.Enqueue(val);
        var lastVal = 0;
        
        if(q.Count() > size) {
            lastVal = q.Dequeue();
            sum-=lastVal;
        }
        
        return sum/q.Count();
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */