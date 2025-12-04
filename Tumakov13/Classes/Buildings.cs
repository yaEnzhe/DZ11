

using System;

namespace Tumakov13.Classes
{
    internal class Buildings
    {
        public static Building[] buildings = new Building[10];
        public Building this[int buildingNum]
        {
            get 
            { 
                foreach(Building building in  buildings)
                {
                    if(building != null && buildingNum == building.BuildingNum)
                    {
                        return buildings[buildingNum];
                    }
                }
                throw new ArgumentException($"Здания {buildingNum} не существует");
            }
            set { buildings[buildingNum] = value; }
        }
        public static Building FindByBuildingNum(int buildingNumber)
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null && buildings[i].BuildingNum == buildingNumber)
                {
                    return buildings[i];
                }
            }
            return null;
        }
    }
}
