using System;
using System.Collections.Generic;

namespace PaintCostCalculator
{
    public class PaintCost
    {
        //Paint Type 1 = true, Type 2 = false
        private bool _ceilingPaintType;
        private bool _wallPaintType;
        private bool _grillPaintType;
        
        private double _ceilingCost;
        private double _wallCost;
        private double _grillCost;
        public double CeilingCost { get { return _ceilingCost; } }
        public double WallCost { get { return _wallCost; } }
        public double GrillCost { get { return _grillCost; } }
        private List<Room> _rooms = new List<Room>();
        public double TotalCost { get { return CeilingCost + WallCost + GrillCost; } }

        public PaintCost(bool ceilingPaintType, bool wallPaintType, bool grillPaintType, List<Room> rooms)
        {
            _ceilingPaintType = ceilingPaintType;
            _wallPaintType = wallPaintType;
            _grillPaintType = grillPaintType;
            _rooms = rooms;
            if (_rooms.Count > 0)
            {
                calculateCost();
            }
        }

        private void calculateCost()
        {
            foreach (Room room in _rooms)
            {
                _ceilingCost += calculateCeilingCost(room);
                _wallCost += calculateWallCost(room);
                _grillCost += calculateGrillCost(room);
            }

        }

        private double calculateCeilingCost(Room room)
        {
            return room.ceilingCost = Math.Round((room.length * room.width) * (_ceilingPaintType ? SystemConstants.CEILING_PAINT_RATE_1 : SystemConstants.CEILING_PAINT_RATE_2),2);
        }

        private double calculateWallCost(Room room)
        {
            return room.wallCost = Math.Round((((2 * room.length + 2 * room.width) * SystemConstants.ROOM_HEIGHT) - (room.noOfWindows * SystemConstants.WINDOW_HEIGHT * SystemConstants.WINDOW_WIDTH) - (room.noOfDoor * SystemConstants.DOOR_HEIGHT * SystemConstants.DOOR_WIDTH)) * (_wallPaintType ? SystemConstants.WALL_PAINT_RATE_1 : SystemConstants.WALL_PAINT_RATE_2),2);
        }

        private double calculateGrillCost(Room room)
        {
            double gridArea = Math.Round((0.15 * (SystemConstants.WINDOW_HEIGHT * SystemConstants.WINDOW_WIDTH)),2);
            return room.grillCost = Math.Round(room.noOfWindows* gridArea * (_grillPaintType ? SystemConstants.GRILL_PAINT_RATE_2 : SystemConstants.GRILL_PAINT_RATE_2),2);
        }
    }
}