using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Point
    {
        #region Fields
        int x = 0;
        int y = 0;
        string name = "";
        #endregion

        #region Properties
        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
        #endregion

        #region Constructors
        public Point(int x, int y, string Name = "Polygon")
        {
            this.x = x;
            this.y = y;
            this.name = Name;
        }
        public Point()
        {

        }
        #endregion
    }
}
