using SlidingWindow;
using System;
using System.Linq;

namespace GrokkingCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 };
            int k = 5;
            var averageOfConSubSizeK = new AverageOfContiguousSubarraySizeK();

            averageOfConSubSizeK.GetAverage(array,k).ToList().ForEach(_=>Console.WriteLine(_));
        }
    }
}
