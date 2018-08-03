using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    public class Matrix<T> : IEnumerable
    {
        private Position<T>[] _matrix;

        public Matrix()
        {
            this._matrix = (Position<T>[])Array.CreateInstance(typeof(Position<T>), 0);
        }

        public Matrix(params Position<T>[] _collection)
        {
            Position<T>[] tempMatrix = new Position<T>[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempMatrix[i] = _collection[i];
            _matrix = tempMatrix;
        }

        public void AddItem(Position<T> newPosition)
        {
            CommonFunc.AddItem(_matrix, newPosition);
        }

        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(_matrix, index);
        }

        public void ClearAll()
        {
            CommonFunc.DefaultInit(out this._matrix);
        }

        public IEnumerator GetEnumerator()
        {
            return _matrix.GetEnumerator();
        }

        public int Length
        {
            get { return _matrix.Length; }
        }

        public Position<T> this[int index]
        {
            get { return _matrix[index]; }
            set { _matrix[index] = value; }
        }
    }
}
