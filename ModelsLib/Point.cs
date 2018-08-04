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
    public class Point<T> : IPoint
    {
        private readonly T coord_X, coord_Y, coord_Z ;

        /// <summary>
        /// Constructor of empty point
        /// </summary>
        /// <param name="x"></param>
        public Point()
        {
        }
        /// <summary>
        /// Constructor of 1D point
        /// </summary>
        public Point(T x)
        {
            if (!CheckTypes(x))
                return;
            this.coord_X = x;            
        }
        /// <summary>
        /// Constructor of 2D point
        /// </summary>
        public Point(T x, T y)
        {
            if (!CheckTypes(x))
                return;
            this.coord_X = x;
            this.coord_Y = y;
        }
        /// <summary>
        /// Constructor of 3D point
        /// </summary>
        public Point(T x, T y, T z)
        {
            if (!CheckTypes(x))
                return;
            this.coord_X = x;
            this.coord_Y = y;
            this.coord_Z = z;
        }
        /// <summary>
        /// Implementation Ipoint Interface: 
        /// Checking a one object.  Return false, 
        /// if type of variable is not int or decimal or double, else return true
        /// </summary>
        /// <param name="_x">An any type object</param>
        /// </summary>
        public bool CheckTypes<U>(U _x)
        {
            Type t = _x.GetType();
            return (t.Equals(typeof(Int32?)) || t.Equals(typeof(decimal?)) || t.Equals(typeof(double?)));
        }
    }
}
