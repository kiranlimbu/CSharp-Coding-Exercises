using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTotalTime
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainTravel undergroundSystem = new TrainTravel();
            undergroundSystem.CheckIn(45, "Leyton", 3);
            undergroundSystem.CheckIn(32, "Paradise", 8);
            undergroundSystem.CheckIn(27, "Leyton", 10);
            undergroundSystem.CheckOut(45, "Waterloo", 15);
            undergroundSystem.CheckOut(27, "Waterloo", 20);
            undergroundSystem.CheckOut(32, "Cambridge", 22);
            double result = undergroundSystem.GetAverageTime("Paradise", "Cambridge");
            Console.WriteLine(result);
        }
    }

    public class TrainTravel
    {
        Dictionary<int, (string stationName, int time)> startTravel = new Dictionary<int, (string stationName, int time)>();
        Dictionary<(string startStation, string endStation), (double timeTaken, int trip)> avgTime = new Dictionary<(string startStation, string endStation), (double timeTaken, int trip)>();

        public TrainTravel()
        {

        }
        public void CheckIn(int id, string stationName, int time)
        {
            startTravel[id] = (stationName, time);
        }

        /* Calculate avg and store the value in avgTime
         id 1, s.time = 3 \	dif = 5	, trip = 1		(preTime * trip + totalTime)/(trip+1)
         id 1, e.time = 8 /						        5

         id 2, s.time = 6 \	dif = 12 , trip = 2 		5 X 1 + 12 / 2 = 8.5
         id 2, e.time = 18/			

         id 3, s.time = 5 \	dif = 7 , trip = 3			8.5 X 2 + 7 / 3 = 8
         id 3, e.time = 12/			
					
         id 4, s.time = 9 \	dif = 6	, trip = 4	 		8 X 3 + 6 / 4 = 7.5
         id 4, e.time = 15/ total avg time = 7.5 
         */
        public void CheckOut(int id, string stationName, int time)
        {
            var (startStation, startTime) = startTravel[id];
            var totalTime = time - startTime;

            var stations = (startStation, stationName);

            if (avgTime.ContainsKey(stations))
            {
                var (preTime, trip) = avgTime[stations];
                var newAvgTime = ((preTime * trip + totalTime)/(trip+1), trip+1);
                avgTime[stations] = newAvgTime;
            }
            else avgTime[stations] = (totalTime, 1);
        }

        public double GetAverageTime(string startStation, string endStation)
        {
            var (result, x) = avgTime[(startStation, endStation)];
            return result;
        }
    }
}
