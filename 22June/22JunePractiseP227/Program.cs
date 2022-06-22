using System;
using System.Collections.Generic;

namespace _22JunePractiseP227
{
    class Program
    {
        static void Main(string[] args)
        {
            int carCount = CarCountInRace();
            List<Car> cars = CreateCars(carCount);
            F1Race f1Race = CreateRace(cars);
            f1Race.CompletedCars();
            f1Race.GetWinner(cars);
        }

        //Create Cars Method
        public static List<Car> CreateCars(int carCount)
        {
            List<Car> cars = new List<Car>(carCount);

            for (int i = 0; i < cars.Capacity; i++)
            {

                Console.Write($"{i + 1}. Masinin brandini daxil edin: ");
                string brand = Console.ReadLine();

                string carMinStr;
                int carMin;
                do
                {
                    Console.Write($"{i + 1}. Masinin Finishe catma deqiqesini daxil edin: ");
                    carMinStr = Console.ReadLine();
                } while (!int.TryParse(carMinStr, out carMin));

                Car car = new Car() { Brand = brand, RaceDurationMinutes = carMin };
                cars.Add(car);
            }
            return cars;
        }

        //Create Race Method
        public static F1Race CreateRace(List<Car> cars)
        {
            string raceStartStr;
            DateTime raceStart;
            do
            {
                Console.Write("Yarisin baslama muddetini daxil edin (mm dd yyyy hh:mm): ");
                raceStartStr = Console.ReadLine();
            } while (!DateTime.TryParse(raceStartStr, out raceStart));

            string raceEndStr;
            DateTime raceEnd;
            do
            {
                Console.Write("Yarisin bitme muddetini daxil edin (mm dd yyyy hh:mm): ");
                raceEndStr = Console.ReadLine();
            } while (!DateTime.TryParse(raceEndStr, out raceEnd));
            F1Race f1Race = new F1Race() { Cars = cars };
            f1Race.RaceStartDate = raceStart;
            f1Race.RaceEndDate = raceEnd;

            return f1Race;
        }

        //How Many Cars will be in Race Method
        public static int CarCountInRace()
        {
            string carCountStr;
            int carCount;
            do
            {
                Console.Write("Neche mashin yarishacaq? - ");
                carCountStr = Console.ReadLine();

            } while (!int.TryParse(carCountStr, out carCount));

            return carCount;
        }
    }
}
