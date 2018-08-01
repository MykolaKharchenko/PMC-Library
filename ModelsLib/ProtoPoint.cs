using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib
{






    public interface IAncestorPoint
    {
        void InitStruct();
    }

    public interface IProtoPoint <T> : IAncestorPoint
    {
        // пока пустой,         
         void CheckTypes(T  _variable);
    }

    public class ProtoPoint<T> : IProtoPoint<T> //where T : struct
    {
        private readonly T coordX_, coord_Y;//= default(T);       
        private static bool Check = true;
        public ProtoPoint() { }
    
        public ProtoPoint(T x, T y)
        {
            CheckTypes(x);
            if (!Check)
                return;
            if (!Check) return;
            this.coordX_ = x;
            this.coord_Y = y;
        }

           public void CheckTypes(T _x)
        {
            Type t = _x.GetType();
            if (t.Equals(typeof(Int32)) || t.Equals(typeof(decimal)) || t.Equals(typeof(double))) { }
            else
                Check = false;
        }

        public virtual void InitStruct()
        {

        }
    } 
}


/*
    public abstract class ProtoPoint
    {
        protected readonly object coordX, coordY, coordZ;

        public ProtoPoint() { }
        public ProtoPoint(object x)
        {
            this.coordX = x;
        }

        public ProtoPoint(object x, object y)
        {
            this.coordX = x;
            this.coordY = y;
        }

        public ProtoPoint(object x, object y, object z)
        {
            this.coordX = x;
            this.coordY = y;
            this.coordZ = z;
        }
    }
     class IntProtoPoint<T> : ProtoPoint
    {
        public IntProtoPoint() : base() { }
        public IntProtoPoint(int coordX) : base(coordX) { }
        public IntProtoPoint(int coordX, int coordY) : base(coordX, coordY) { }
        public IntProtoPoint(int coordX, int coordY, int coordZ) : base(coordX, coordY, coordZ) { }

    }
    public class DoubleProtoPoint<T> : ProtoPoint
    {
        public DoubleProtoPoint() : base() { }
        public DoubleProtoPoint(double coordX) : base(coordX) { }
        public DoubleProtoPoint(double coordX, double coordY) : base(coordX, coordY) { }
        public DoubleProtoPoint(double coordX, double coordY, double coordZ) : base(coordX, coordY, coordZ) { }
    }
    public class DecimalProtoPoint<T> : ProtoPoint
    {
        public DecimalProtoPoint() : base() { }
        public DecimalProtoPoint(decimal coordX) : base(coordX) { }
        public DecimalProtoPoint(decimal coordX, decimal coordY) : base(coordX, coordY) { }
        public DecimalProtoPoint(decimal coordX, decimal coordY, decimal coordZ) : base(coordX, coordY, coordZ) { }
    }
*/
