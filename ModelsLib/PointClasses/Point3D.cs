using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.PointClasses
{
    /// <summary>
    /// The Point3D<T> class provides describe  the  object  of  3D point
    /// </summary>
    public class Point3D<T> : Point<T>
    {
        public readonly T coord_X, coord_Y, coord_Z;

        /// <summary>
        /// constructor of 3D point
        /// </summary>
        public Point3D(T x, T y, T z)
        {
            if (!CheckTypes(x))
                return;
            this.coord_X = x;
            this.coord_Y = y;
            this.coord_Z = z;
        }
    }
}
