using System;

namespace Histogram {
  public class Histogram {
    private int[] counters;
    private double[] limits; 
    public Histogram(double maxLimit, double minLimit, int numOfCounter = 10) {
       counters = new int[numOfCounter];
       limits = new double[numOfCounter];
       SetInterval(numOfCounter, maxLimit, minLimit);
    }
    public void Add(double x) {
      foreach (double limit in limits)
        if (x < limit) counters[Array.IndexOf(limits, limit)]++;
    }
    public void Reset() {
      for(int i = 0; i < counters.Length; i++)
        counters[i] = 0;
    }
    private void SetInterval(int numOfInterval, double maxLimit, double minLimit) {
      double tempLimit = 0;
      for(int i = 0; i < numOfInterval; i++) {
        limits[i] = tempLimit + (maxLimit - minLimit) / numOfInterval;
        tempLimit += limits[i]; 
      }
    }

  }
}