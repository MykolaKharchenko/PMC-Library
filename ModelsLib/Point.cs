﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib.Interfaces;

namespace ModelsLib
{
    public class Point<T> : IPoint //where T : struct
    {
        private readonly T coordX_, coord_Y, coord_Z;//= default(T);       
        //public Point() { }
        public Point(T x)
        {

            if (!CheckTypes(x))
                return;
            this.coordX_ = x;
        }
        public Point(T x, T y)
        {
            if (!CheckTypes(x))
                return;
            this.coordX_ = x;
            this.coord_Y = y;
        }
        public Point(T x, T y, T z)
        {
            if (!CheckTypes(x))
                return;
            this.coordX_ = x;
            this.coord_Y = y;
            this.coord_Z = z;
        }

        public virtual bool CheckTypes<T>(T _x)
        {
            Type t = _x.GetType();
            return (t.Equals(typeof(Int32)) || t.Equals(typeof(decimal)) || t.Equals(typeof(double)));
        }

    }
}