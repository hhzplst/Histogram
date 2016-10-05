using System;

namespace Histogram {
    public class HistogramTest {
        public static void Main(string[] args) {

            Histogram myHistogram = new Histogram(0, 1);
            Random randomObj = new Random();
            for (int i = 0; i < 10000; i++)
                myHistogram.Add(randomObj.NextDouble());
            myHistogram.PlotFrequency();  
            myHistogram.PlotCumulative();     
        }        
    }
}