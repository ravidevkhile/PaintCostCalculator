namespace PaintCostCalculator
{
    public class Room
    {
        private double _length;
        private double _width;
        private int _noOfWindows;
        private int _noOfDoor;
        private double _ceilingCost;
        private double _wallCost;
        private double _grillCost;
        public double ceilingCost { get { return _ceilingCost; } set { _ceilingCost = value; } }
        public double wallCost { get { return _wallCost; } set { _wallCost = value; } }
        public double grillCost { get { return _grillCost; } set { _grillCost = value; } }

        public double length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int noOfWindows
        {
            get { return _noOfWindows; }
            set { _noOfWindows = value; }
        }

        public int noOfDoor
        {
            get { return _noOfDoor; }
            set { _noOfDoor = value; }
        }

        public Room(double length, double width, int noOfWindows, int noOfDoor)
        {
            _length = length;
            _width = width;
            _noOfWindows = noOfWindows;
            _noOfDoor = noOfDoor;
        }
    }
}