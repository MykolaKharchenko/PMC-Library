using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.PointClasses
{
    /// <summary>
    /// The Point1D<T> class provides describe  the  object  of  1D point
    /// </summary>
    public class Point1D<T> : Point<T>
    {
        public readonly T coord_X;
        /// <summary>
        /// constructor of 1D point
        /// </summary>
        public Point1D(T x)
        {
            if (!CheckTypes(x))
                return;
            this.coord_X = x;
        }
    }
}
