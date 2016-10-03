using System;

namespace Histogram {
    public class HistogramTest {
        public static void Main(string[] args) {


            Histogram myHistogram = new Histogram(0, 1);
            myHistogram.PlotFrequency();
        }        
    }
}