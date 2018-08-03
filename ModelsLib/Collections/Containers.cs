using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    public class Containers<T>
    {
        public Container<T>[] _containers;

        public Containers()
        {
            this._containers = (Container<T>[])Array.CreateInstance(typeof(Container<T>), 0);
        }

        public void AddItem(Container<T> newContainer)
        {
            CommonFunc.AddItem(_containers, newContainer);
        }

        //public void RemoveItem(int index)
        //{
        //    CommonFunc.RemoveItem<IContainer>(_containers, index);
        //}

        //public void ClearAll()
        //{
        //    CommonFunc.DefaultInit(this._containers);
        //}

        //public IEnumerator GetEnumerator()
        //{
        //    return _containers.GetEnumerator();
        //}

        //public int Length
        //{
        //    get { return _containers.Length; }
        //}

        //public IContainer this[int index]
        //{
        //    get { return _containers[index]; }
        //    set { _containers[index] = value; }
        //}
    }
}
