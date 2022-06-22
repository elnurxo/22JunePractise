using System;
using System.Collections.Generic;
using System.Text;

namespace _22JunePractiseP227
{
    public class F1Race
    {
        public List<Car> Cars = new List<Car>();

        public DateTime RaceStartDate;
        public DateTime RaceEndDate;

        public void CompletedCars()
        {
            List<Car> completedCars = Cars.FindAll(x => x.RaceDurationMinutes <= (RaceEndDate - RaceStartDate).TotalMinutes);

            foreach (var item in completedCars)
            {
                Console.WriteLine($"{item.Brand} - {item.No}, completed race successfully!");
            }
        }

        public void GetWinner(List<Car> Cars)
        {
            int result = Cars[0].RaceDurationMinutes;
            Car Winner=Cars[0];
            for (int i = 1; i < Cars.Count; i++)
            {
                if (result>Cars[i].RaceDurationMinutes)
                {
                    result = Cars[i].RaceDurationMinutes;
                    Winner = Cars[i];
                }
            }

            Console.WriteLine($"{Winner.Brand}, completed race in {result} minutes!");
        }
    }
}
