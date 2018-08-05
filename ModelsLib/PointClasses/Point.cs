using ModelsLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.PointClasses
{
    /// <summary>
    /// The Point<T> class provides the  object  of  the simplest element is a data point. 
    /// This is a generic type describing the simplest shape in 1D, 2D or 3D. 
    /// </summary>
    /// <typeparam name="T">int or double or decimal</typeparam>
    public class Point<T> : IPoint
    {
        /// <summary>
        /// Implementation Ipoint Interface: 
        /// Checking a one object.  Return false, 
        /// if type of variable is not int or decimal or double, else return true
        /// </summary>
        /// <param name="_x">An any type object</param>
        /// </summary>
        public bool CheckTypes<U>(U _variable)
        {
            Type t = _variable.GetType();
            return (t.Equals(typeof(Int32)) || t.Equals(typeof(decimal)) || t.Equals(typeof(double)));
        }
    }
}
