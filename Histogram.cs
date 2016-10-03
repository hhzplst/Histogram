using System;

namespace Histogram {
  public class Histogram {
    private int[] counters;
    private double[] limits; 
    public Histogram(int numOfCounter, double maxLimit, double minLimit) {
       counters = new int[numOfCounter];
       limits = new double[numOfCounter];
       limits[0] = minLimit;
       limits[numOfCounter - 1] = maxLimit;
    }
    public Histogram(double maxLimit, double minLimit) {
      counters = new int[10];
      limits = new double[10];
      limits[0] = minLimit;
      limits[9] = maxLimit;
    }
    public void Add(double x) {
      foreach (double limit in limits)
        if (x < limit) counters[Array.IndexOf(limits, limit)]++;
    }
    
    public void Reset() {
      for(int i = 0; i < counters.Length; i++)
        counters[i] = 0;
    }

  }
}