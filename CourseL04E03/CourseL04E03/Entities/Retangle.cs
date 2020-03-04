using System;

namespace CourseL04E03.Entities
{
    class Retangle
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return (Height * 2) + (Width * 2);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Height * Height) + (Width * Width));
        }
    }
}
