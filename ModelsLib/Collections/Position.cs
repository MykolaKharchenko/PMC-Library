using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib.Interfaces;
using ModelsLib.PointClasses;

namespace ModelsLib.Collections
{
    /// <summary>
    /// The Position<T> class provides the  object  of an array of Points.
    /// </summary>
    public class Position<T> : IEnumerable
    {
        /// <summary>
        /// array of Points
        /// </summary>
        private Point<T>[] _position;     

        /// <summary>
        /// default constructor
        /// </summary>
        public Position()
        {
            CommonFunc.DefaultInit(out _position);
        }

        /// <summary>
        /// constructor for many members(Point)
        /// </summary>
        /// <param name="_collection"></param>
        public Position(params Point<T>[] _collection)
        {
            Point<T>[] tempPosition = new Point<T>[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempPosition[i] = _collection[i];
            _position = tempPosition;
        }
        /// <summary>
        /// add new item in current array of Points
        /// </summary>
        public void AddItem(Point<T> newPoint)
        {
            CommonFunc.AddItem(ref _position, newPoint);
        }

        /// <summary>
        /// remove item from current array of Points
        /// </summary>
        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(ref _position, index);
        }

        /// <summary>
        /// remove all items from current array of Points
        /// </summary>
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
    }
}
