using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Interfaces
{
    /// <summary>
    /// The IPoint interface implements a method that check point's coords to single type.
    /// </summary>
    public interface IPoint
    {
        /// <summary>
        /// Compares one object. An implementation of this method must return a
        /// false, if type of variable is not int or decimal or double 
        /// else  true
        /// </summary>
        /// <param name="_variable">An any type object</param>        
        bool CheckTypes<T>(T _variable);
    }
}
