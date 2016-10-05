using System;

namespace Histogram {
  public class Histogram {
    private int[] counters;
    private int[] cumulativeCounters;
    private double[] limits; 
    public Histogram(double minLimit, double maxLimit, int numOfCounter = 10) {
      if (minLimit >= maxLimit)
        throw new ArgumentException("Maximum limit must be greater than the minimum limit!");
       counters = new int[numOfCounter];
       cumulativeCounters = new int[numOfCounter];

       limits = new double[numOfCounter + 1];
       SetInterval(numOfCounter, minLimit, maxLimit);
    }
    public void Add(double x) {
      for (int i = 1; i < limits.Length; i++) {
        if (x < limits[i] && x >= limits[i - 1])
          counters[Array.IndexOf(limits, limits[i]) - 1]++;
      }
      AddCumulate(x);
    }
    private void AddCumulate(double x) {
      foreach (double limit in limits)
        if (x < limit) cumulativeCounters[Array.IndexOf(limits, limit) - 1]++;
    }
    public void Reset() {
      for (int i = 0; i < counters.Length; i++) {
        counters[i] = 0;
        cumulativeCounters[i] = 0;
      }
        
    }
    private void SetInterval(int numOfInterval, double minLimit, double maxLimit) {
      limits[0] = minLimit;
      for (int i = 1; i < numOfInterval + 1; i++) {
        limits[i] = limits[i - 1] + (maxLimit - minLimit) / numOfInterval;
      }
    }
    public void PlotFrequency() {
      PlotHeader();
      for (int i = 0; i < counters.Length; i++)
        Console.WriteLine("{0, -15}{1, 20}{2, 13}\n", $"Counter {i}", $"{limits[i]} <= x < {limits[i+1]}", counters[i]);
    }
    public void PlotCumulative() {
      PlotHeader();
      for (int i = 0; i < cumulativeCounters.Length; i++)
        Console.WriteLine("{0, -15}{1, 20}{2, 13}\n", $"Counter {i}", $"{limits[i]} <= x < {limits[i+1]}", cumulativeCounters[i]);
    }
    private void PlotHeader() {
      Console.WriteLine("\n\n{0, -10}{1, 17}{2, 20}\n" + 
                        "****************************************************\n", 
                                           "Counter Number", "Limits", "Frequency");
    }
  }
}