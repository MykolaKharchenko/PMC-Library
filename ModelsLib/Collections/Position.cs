using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib.Interfaces;

namespace ModelsLib.Collections
{
    public class Position<T> : IEnumerable
    {
        public Point<T>[] _position;
        public Position()
        {
            //this._position = (IPoint[])Array.CreateInstance(typeof(IPoint), 0);
            //this._position =
                CommonFunc.DefaultInit(out _position);
        }

        public Position(params Point<T>[] _collection)
        {
            Point<T>[] tempPosition = new Point<T>[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempPosition[i] = _collection[i];
            _position = tempPosition;
        }

        public void AddItem(IPoint[] thisPosition, IPoint newPoint)
        {
            CommonFunc.AddItem<IPoint>(thisPosition, newPoint);
        }

        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<IPoint>(_position, index);
        }

        public void ClearAll()
        {
            CommonFunc.DefaultInit(out this._position);
        }

        public IEnumerator GetEnumerator()
        {
            return _position.GetEnumerator();
        }

        public int Length
        {
            get { return _position.Length; }
        }

        public Point<T> this[int index]
        {
            get { return _position[index]; }
            set { _position[index] = value; }
        }

        public bool CheckTypes<U>(U _x)
        {
            Type t = _x.GetType();
            return (t.Equals(typeof(Int32)) || t.Equals(typeof(decimal)) || t.Equals(typeof(double)));
        }
    }
}
