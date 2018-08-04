using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    /// <summary>
    /// The Matrix<T> class provides the  object  of an array of Position.
    /// </summary>
    public class Matrix<T> : IEnumerable
    {
        /// <summary>
        /// array of Positions
        /// </summary>
        private Position<T>[] _matrix;

        /// <summary>
        /// default constructor
        /// </summary>
        public Matrix()
        {
            CommonFunc.DefaultInit(out _matrix);
        }

        /// <summary>
        /// constructor for many members(Position)
        /// </summary>
        public Matrix(params Position<T>[] _collection)
        {
            Position<T>[] tempMatrix = new Position<T>[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempMatrix[i] = _collection[i];
            _matrix = tempMatrix;
        }

        /// <summary>
        /// add new item in current array of Positions
        /// </summary>
        public void AddItem(Position<T> newPosition)
        {
            CommonFunc.AddItem(ref _matrix, newPosition);
        }

        /// <summary>
        /// remove item from current array of Positions
        /// </summary>
        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(ref _matrix, index);
        }

        /// <summary>
        /// remove all items from current array of Positions
        /// </summary>
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
