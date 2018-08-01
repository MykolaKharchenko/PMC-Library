using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    public class Container : IEnumerable
    {
        private Matrix[] _container;

        public Container()
        {
            this._container = (Matrix[])Array.CreateInstance(typeof(Matrix), 0);
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
