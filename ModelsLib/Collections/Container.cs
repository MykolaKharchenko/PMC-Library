using ModelsLib.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    /// <summary>
    /// The Container<T> class provides the  object  of an array of Matrices.
    /// </summary>
    public class Container<T> : IEnumerable
    {
        /// <summary>
        /// array of Matrices
        /// </summary>
        private Matrix<T>[] _container;

        /// <summary>
        /// default constructor
        /// </summary>
        public Container()
        {
            CommonFunc.DefaultInit(out _container);
        }

        /// <summary>
        /// constructor for many members(Matrix)
        /// </summary>
        public Container(params Matrix<T>[] _collection)
        {
            Matrix<T>[] tempContainer = new Matrix<T>[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempContainer[i] = _collection[i];
            _container = tempContainer;
        }

        /// <summary>
        /// add new item in current array of Matrices
        /// </summary>
        public void AddItem(Matrix<T> newMatrix)
        {
            CommonFunc.AddItem(ref _container, newMatrix);
        }

        /// <summary>
        /// remove item from current array of Matrices
        /// </summary>
        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(ref _container, index);
        }

        /// <summary>
        /// remove all items from current array of Matrices
        /// </summary>
        public void ClearAll()
        {
            CommonFunc.DefaultInit(out this._container);
        }

        public IEnumerator GetEnumerator()
        {
            return _container.GetEnumerator();
        }

        public int Length
        {
            get { return _container.Length; }
        }

        public Matrix<T> this[int index]
        {
            get { return _container[index]; }
            set { _container[index] = value; }
        }
    }
}
