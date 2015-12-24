using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Rectangle
    {
        #region Fields
        double side1 = 0;
        double side2 = 0;
        #endregion

        #region Properties
        private double Area
        {
            get { return AreaCalculator(); }
        }
        private double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
        #endregion

        #region Constructor
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        #endregion

        #region Methods
        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public override string ToString()
        {
            return string.Format("Area: {0} | Perimeter {1} ", Area, Perimeter);
        }
        #endregion

    }
}
