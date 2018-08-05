using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.PointClasses
{
    /// <summary>
    /// The Point2D<T> class provides describe  the  object  of  2D point
    /// </summary>
    public class Point2D<T> : Point<T>
    {
        public readonly T coord_X, coord_Y;

        /// <summary>
        /// constructor of 2D point
        /// </summary>
        public Point2D(T x, T y)
        {
            if (!CheckTypes(x))
                return;
            this.coord_X = x;
            this.coord_Y = y;
        }
    }
}
