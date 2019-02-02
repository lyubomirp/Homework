using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Box
    {
        private double length;

        private double width;

        private double height;


        public double Length
        {
            get => this.length;
            set
            {
                this.length = value;
                if (length <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
            }
        }

        public double Width
        {
            get => this.width;
            set
            {
                this.width = value;
                if (width <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
            }
        }

        public double Height
        {
            get => this.height;
            set
            {
                this.height = value;
                if (height <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
            }
        }

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }


        public static double Volume(double length, double width, double height)
        {
                return length * width * height;
        }

        public static double LateralSurface(double length, double width, double height)
        {
            return 2 * (length * height) + 2 * (width * height);
        }

        public static double SurfaceArea(double length, double width, double height)
        {
            return 2 * (length*width) + 2 * (length*height) + 2 * (width*height);
        }
    }
}
