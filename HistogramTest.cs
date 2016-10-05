using System;

namespace Histogram {
    public class HistogramTest {
        public static void Main(string[] args) {
            Random randomObj = new Random();
            Console.WriteLine("Generating Histogram from 0 to 1.0...");
            Histogram myHistogram = new Histogram(0, 1);
            
            for (int i = 0; i < 10000; i++)
                myHistogram.Add(randomObj.NextDouble());
            myHistogram.PlotFrequency();  
            myHistogram.PlotCumulative();

            Console.WriteLine("Resetting the Histogram...");
            myHistogram.Reset(); 

            Console.WriteLine("Generating Histogram from 0 to 10...");
            myHistogram = new Histogram(0, 10); 

            for (int i = 0; i < 1000; i++) {
                double temp = 0;
                for (int j = 0; j < 10; j++) 
                    temp += randomObj.NextDouble();
                myHistogram.Add(temp);
            }
            myHistogram.PlotFrequency();  
            myHistogram.PlotCumulative();
        }        
    }
}

/********************************************TEST OUTPUT********************************************

➜  Histogram git:(master) ✗ dotnet run
Project Histogram (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling Histogram for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.4099064
 

Generating Histogram from 0 to 1.0...


Counter Number           Limits           Frequency
****************************************************

Counter 0              0 <= x < 0.1         1025

Counter 1            0.1 <= x < 0.2          991

Counter 2            0.2 <= x < 0.3         1007

Counter 3            0.3 <= x < 0.4          987

Counter 4            0.4 <= x < 0.5          982

Counter 5            0.5 <= x < 0.6          990

Counter 6            0.6 <= x < 0.7         1009

Counter 7            0.7 <= x < 0.8          965

Counter 8            0.8 <= x < 0.9         1017

Counter 9              0.9 <= x < 1         1027



Counter Number           Limits           Frequency
****************************************************

Counter 0              0 <= x < 0.1         1025

Counter 1            0.1 <= x < 0.2         2016

Counter 2            0.2 <= x < 0.3         3023

Counter 3            0.3 <= x < 0.4         4010

Counter 4            0.4 <= x < 0.5         4992

Counter 5            0.5 <= x < 0.6         5982

Counter 6            0.6 <= x < 0.7         6991

Counter 7            0.7 <= x < 0.8         7956

Counter 8            0.8 <= x < 0.9         8973

Counter 9              0.9 <= x < 1        10000

Resetting the Histogram...
Generating Histogram from 0 to 10...


Counter Number           Limits           Frequency
****************************************************

Counter 0                0 <= x < 1            0

Counter 1                1 <= x < 2            0

Counter 2                2 <= x < 3           11

Counter 3                3 <= x < 4          135

Counter 4                4 <= x < 5          367

Counter 5                5 <= x < 6          356

Counter 6                6 <= x < 7          111

Counter 7                7 <= x < 8           19

Counter 8                8 <= x < 9            1

Counter 9               9 <= x < 10            0



Counter Number           Limits           Frequency
****************************************************

Counter 0                0 <= x < 1            0

Counter 1                1 <= x < 2            0

Counter 2                2 <= x < 3           11

Counter 3                3 <= x < 4          146

Counter 4                4 <= x < 5          513

Counter 5                5 <= x < 6          869

Counter 6                6 <= x < 7          980

Counter 7                7 <= x < 8          999

Counter 8                8 <= x < 9         1000

Counter 9               9 <= x < 10         1000


*******************************************END TEST OUTPUT******************************************/