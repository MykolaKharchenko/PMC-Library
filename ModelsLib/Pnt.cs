using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{
    public class Pnt<T> where T : struct
    {
        private readonly T coord_X, coord_Y, coord_Z;
        private readonly T _coord_X, _coord_Y, _coord_Z;
        
        public T? X
        {
            get { return coord_X; }
            set
            {
                if (_coord_X.ToString().Length > 0)
                    value = _coord_X;
                else
                    value = null;
            }
        }
        public T? Y
        {
            get { return coord_Y; }
            set
            {
                if (_coord_Y.ToString().Length > 0)
                    value = _coord_Y;
                else
                    value = null;
            }
        }
        public T? Z
        {
            get { return coord_Z; }
            set
            {
                if (_coord_Z.ToString().Length > 0)
                    value = _coord_Z;
                else
                    value = null;
            }
        }

        public Pnt(T x)
        {
            this._coord_X = x;
        }
        public Pnt(T x, T y)
        {
            this._coord_X = x;
            this._coord_Y = y;
        }
        public Pnt(T x, T y, T z)
        {
            this._coord_X = x;
            this._coord_Y = y;
            this._coord_Z = z;
        }



    }

    //public class MegaPoint<T> : Pnt<T> 
    //{    
    //    private readonly T? coord_X, coord_Y, coord_Z;

    //    public MegaPoint(params[] prms) : base(x, y, z)
    //    {
    //        coord_X = beak;
    //    }
    //}
}
