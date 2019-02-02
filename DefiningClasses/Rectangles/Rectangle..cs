using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangles
{
    class Rectangle
    {

        private string id;
        private double width;
        private double height;
        private double[] coordinates;

        public Rectangle(string id, double width, double height, double[] coords)
        {
            this.id = id;
            this.width = Math.Abs(width);
            this.height = Math.Abs(height);
            this.coordinates = coords;
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public double Width { get { return width; } }
        public double Height { get { return height; } }
        public double[] Coordinates { get { return coordinates; } }


        public static bool Intersect (Rectangle first, Rectangle second)
        {
            if(first.Coordinates[0] <= (second.Coordinates[0]+second.Width) && (first.Coordinates[0]+first.Width) >= second.Coordinates[0]
                && first.Coordinates[1] <= (second.Coordinates[1] + second.Height) && (first.Coordinates[1] + first.Height) >= second.Coordinates[1])
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
