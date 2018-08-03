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
        private Matrix[] _container;

        public Container()
        {
            this._container = (Matrix[])Array.CreateInstance(typeof(Matrix), 0);
        }

        public Container(params Matrix[] _collection)
        {
            Matrix[] tempContainer = new Matrix[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempContainer[i] = _collection[i];
            _container = tempContainer;
        }

        public void AddItem(Matrix newMatrix)
        {
            CommonFunc.AddItem<Matrix>(_container, newMatrix);
        }

        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Matrix>(_container, index);
        }

        public void ClearAll()
        {
            CommonFunc.DefaultInit(this._container);
        }

        public IEnumerator GetEnumerator()
        {
            return _container.GetEnumerator();
        }

        public int Length
        {
            get { return _container.Length; }
        }

        public Matrix this[int index]
        {
            get { return _container[index]; }
            set { _container[index] = value; }
        }
    }
}
