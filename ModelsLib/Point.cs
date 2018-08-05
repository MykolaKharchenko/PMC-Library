using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib.Interfaces;

namespace ModelsLib
{
    /// <summary>
    /// The Point<T> class provides the  object  of  the simplest element is a data point. 
    /// This is a generic type describing the simplest shape in 1D, 2D or 3D. 
    /// </summary>
    /// <typeparam name="T">int or double or decimal</typeparam>
    public class Point<T>
    {
        /// <summary>
        /// Implementation Ipoint Interface: 
        /// Checking a one object.  Return false, 
        /// if type of variable is not int or decimal or double, else return true
        /// </summary>
        /// <param name="_x">An any type object</param>
        /// </summary>
        public virtual bool CheckingTypes<T>(T _variable)
        {
            Type t = _variable.GetType();
            return (t.Equals(typeof(Int32)) || t.Equals(typeof(decimal)) || t.Equals(typeof(double)));
        }
    }
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
            if (!CheckingTypes(x))
                return;
            this.coord_X = x;
        }
    }
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
            if (!CheckingTypes(x))
                return;
            this.coord_X = x;
            this.coord_Y = y;
        }
    }
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
            if (!CheckingTypes(x))
                return;
            this.coord_X = x;
            this.coord_Y = y;
            this.coord_Z = z;
        }
    }

}
