using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Figure
    {
        #region Fields
        double perimeter = 0;
        Point[] array;
        #endregion

        #region Properties
        string Name { get; set; }
        double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }
        #endregion

        #region Constructors
        public Figure(Point A, Point B, Point C)
        {
            array = new Point[3];
            array[0] = A;
            array[1] = B;
            array[2] = C;
            this.Name = A.Name;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            array = new Point[4];
            array[0] = A;
            array[1] = B;
            array[2] = C;
            array[3] = D;
            this.Name = A.Name;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            array = new Point[5];
            array[0] = A;
            array[1] = B;
            array[2] = C;
            array[3] = D;
            array[4] = E;
            this.Name = A.Name;
        }
        #endregion

        #region Methods
        static double LengthSide(Point A, Point B)
        {
            return (Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)));

        }
        void PerimeterCalculator()
        {
            for (int i = 1; i < array.GetLength(0); i++)
            {
                Perimeter += LengthSide(array[i - 1], array[i]);
            }
            Perimeter += LengthSide(array[0], array[array.GetLength(0) - 1]);
        }
        public void Display()
        {
            PerimeterCalculator();
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Perimeter: {0}", Perimeter);

        }
        #endregion
    }
}
