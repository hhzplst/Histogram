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

Time elapsed 00:00:02.2725519
 

Generating Histogram from 0 to 1.0...


Counter        Limits              Frequency           Bar
*********************************************************************

Counter 0      0 <= x < 0.1        918          #################

Counter 1      0.1 <= x < 0.2      1025         ###################

Counter 2      0.2 <= x < 0.3      1041         ####################

Counter 3      0.3 <= x < 0.4      994          ###################

Counter 4      0.4 <= x < 0.5      953          ##################

Counter 5      0.5 <= x < 0.6      1025         ###################

Counter 6      0.6 <= x < 0.7      979          ##################

Counter 7      0.7 <= x < 0.8      1025         ###################

Counter 8      0.8 <= x < 0.9      1008         ###################

Counter 9      0.9 <= x < 1        1032         ###################



Counter        Limits              Qumulative          Bar
*********************************************************************

Counter 0      0 <= x < 0.1        918          #              

Counter 1      0.1 <= x < 0.2      1943         ###            

Counter 2      0.2 <= x < 0.3      2984         #####          

Counter 3      0.3 <= x < 0.4      3978         #######        

Counter 4      0.4 <= x < 0.5      4931         #########      

Counter 5      0.5 <= x < 0.6      5956         ###########    

Counter 6      0.6 <= x < 0.7      6935         #############  

Counter 7      0.7 <= x < 0.8      7960         ###############

Counter 8      0.8 <= x < 0.9      8968         #################

Counter 9      0.9 <= x < 1        10000        ####################

Resetting the Histogram...
Generating Histogram from 0 to 10...


Counter        Limits              Frequency           Bar
*********************************************************************

Counter 0      0 <= x < 1          0                           

Counter 1      1 <= x < 2          0                           

Counter 2      2 <= x < 3          8                           

Counter 3      3 <= x < 4          131          #######        

Counter 4      4 <= x < 5          364          ####################

Counter 5      5 <= x < 6          363          ###################

Counter 6      6 <= x < 7          119          ######         

Counter 7      7 <= x < 8          13                          

Counter 8      8 <= x < 9          2                           

Counter 9      9 <= x < 10         0                           



Counter        Limits              Qumulative          Bar
*********************************************************************

Counter 0      0 <= x < 1          0                           

Counter 1      1 <= x < 2          0                           

Counter 2      2 <= x < 3          8                           

Counter 3      3 <= x < 4          139          ##             

Counter 4      4 <= x < 5          503          ##########     

Counter 5      5 <= x < 6          866          #################

Counter 6      6 <= x < 7          985          ###################

Counter 7      7 <= x < 8          998          ###################

Counter 8      8 <= x < 9          1000         ####################

Counter 9      9 <= x < 10         1000         ####################


*******************************************END TEST OUTPUT******************************************/