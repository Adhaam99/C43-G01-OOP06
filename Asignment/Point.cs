using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment
{
    class Point : ICloneable
    {
        

        #region Properties

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        #endregion

        #region Constructors

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public object Clone()
        {

            return new Point() 
            { 
                X = this.X,
                Y = this.Y,
                Z = this.Z 
            };        

        }

        #endregion
    }
}
