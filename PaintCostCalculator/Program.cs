using System;
using System.Collections.Generic;

namespace PaintCostCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int totalRoom;
            bool _ceilingPaintType;
            bool _wallPaintType;
            bool _grillPaintType;
            Console.WriteLine("Enter Number of Rooms");
            if (int.TryParse(Console.ReadLine(), out totalRoom))
            {
                Console.WriteLine("Enter Ceiling Paint Type 0 OR 1");

                _ceilingPaintType = (Console.ReadLine() == "1");
                Console.WriteLine("Enter wall Paint Type 0 OR 1");
                _wallPaintType = (Console.ReadLine() == "1");
                Console.WriteLine("Enter Grill Paint Type 0 OR 1");
                _grillPaintType = (Console.ReadLine() == "1");
                double _length;
                double _width;
                int _noOfWindows;
                int _noOfDoor;

                List<Room> _rooms = new List<Room>();
                for (int i = 1; i <= totalRoom; i++)
                {
                    Console.WriteLine("Enter Room Details For Room No. :" + i.ToString());

                    Console.WriteLine("Enter Room length (in feet):");
                    Double.TryParse(Console.ReadLine(), out _length);
                    Console.WriteLine("Enter Room _width (in feet):");
                    Double.TryParse(Console.ReadLine(), out _width);
                    Console.WriteLine("Enter no Of Windows in Room:");
                    int.TryParse(Console.ReadLine(), out _noOfWindows);
                    Console.WriteLine("Enter no Of Door in Room:");
                    int.TryParse(Console.ReadLine(), out _noOfDoor);
                    _rooms.Add(new Room(_length, _width, _noOfWindows, _noOfDoor));
                }
                PaintCost paint = new PaintCost(_ceilingPaintType, _wallPaintType, _grillPaintType, _rooms);
                Console.WriteLine("PaintCost");
                Console.WriteLine("Ceiling paint cost:" + paint.CeilingCost);
                Console.WriteLine("Wall paint cost:" + paint.WallCost);
                Console.WriteLine("Grill paint cost:" + paint.GrillCost);
                Console.WriteLine("Total paint cost:" + paint.TotalCost);
                Console.WriteLine("Done Thanks");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Number");
                Console.ReadLine();
            }
        }
    }
}