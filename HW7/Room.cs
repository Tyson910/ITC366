using System;
namespace HW7
{
    public class Room
    {
        public int Height, Width, Len, Area, Gallons;

        public Room(int height, int width, int len)
        {
            this.Height = height;
            this.Width = width;
            this.Len = len;
            calcAreaOfRoom();
            calcPaintNeeded();
        }

        private void calcAreaOfRoom()
        {
            int areaOfOneWall = Width * Len;
            this.Area = areaOfOneWall * 4;
        }

        private void calcPaintNeeded()
        {
            this.Gallons = (Area / 350) + 1;
        }
    }
}
