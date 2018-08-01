using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib.Interfaces;

namespace ModelsLib
{
    public class Position : IEnumerable
    {
        public IPoint[] _position;
        public Position()
        {
            this._position = (IPoint[])Array.CreateInstance(typeof(IPoint), 0);
        }

        public Position(params IPoint[] _collection)
        {
            IPoint[] tempPosition = new IPoint[_collection.Length];
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
            CommonFunc.DefaultInit(this._position);
        }

        public IEnumerator GetEnumerator()
        {
            return _position.GetEnumerator();
        }

        public int Length
        {
            get { return _position.Length; }
        }

        public IPoint this[int index]
        {
            get { return _position[index]; }
            set { _position[index] = value; }
        }
    }
}
