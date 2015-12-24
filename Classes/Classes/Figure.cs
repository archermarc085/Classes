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
        public Figure(Point[] massive)
        {
            array = new Point[massive.GetLength(0)];
            Array.Copy(massive, array, massive.GetLength(0));
            this.Name = massive[0].Name;
        }
        public Figure(Point A, Point B, Point C)
        {
            array = new Point[3];
            this.Name = Name;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            array = new Point[4];
            this.Name = Name;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            array = new Point[5];
            this.Name = Name;
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
