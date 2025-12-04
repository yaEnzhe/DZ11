using System;

namespace Tumakov13.Classes
{
    internal class Building
    {
        public long BuildingNum { get; set; }
        private static long LastBuildingNum { get; set; } = 1;
        public double Height { get; set; }
        public int Floors { get; set; }
        public int FlatsInBuilding { get; set; }
        public int Entrances { get; set; }
        public Building(double height, int floors, int flatsInBuilding, int entrances)
        {
            BuildingNum = GenerateBuildingNum();
            Height = height;
            Floors = floors;
            FlatsInBuilding = flatsInBuilding;
            Entrances = entrances;
        }
        public static long GenerateBuildingNum()
        {
            return LastBuildingNum++;
        }
        
        public static double HeightOfFloor(int height, int floors)
        {
            double heightOfFloor = height / floors;
            return heightOfFloor;
        }

        public static int FlatsInEntrance(int flatsInBuilding, int entrances)
        {
            int flatsInEntrance = flatsInBuilding / entrances;
            return flatsInEntrance;
        }

        public static int FlatsOnFloor(int flatsInEntrance, int floors)
        {
            int flatsOnFloor = flatsInEntrance / floors;
            return flatsOnFloor;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nНомер дома: {BuildingNum} \nКоличество этажей: {Floors} \nКоличество подъездов: {Entrances} \nКоличество квартир в доме: {FlatsInBuilding}");
        }
    }
}
