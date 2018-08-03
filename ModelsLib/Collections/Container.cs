using ModelsLib.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    public class Container<T> : IEnumerable, IContainer
    {
        private Matrix<T>[] _container;

        public Container()
        {
            this._container = (Matrix<T>[])Array.CreateInstance(typeof(Matrix<T>), 0);
        }

        public Container(params Matrix<T>[] _collection)
        {
            Matrix<T>[] tempContainer = new Matrix<T>[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempContainer[i] = _collection[i];
            _container = tempContainer;
        }

        public void AddItem(Matrix<T> newMatrix)
        {
            CommonFunc.AddItem(_container, newMatrix);
        }

        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(_container, index);
        }

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
