using ModelsLib.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.Collections
{
    public class Containers
    {
        private Container[] _containers;

        public Containers()
        {
            this._containers = (Container[])Array.CreateInstance(typeof(Container), 0);
        }

        public void AddItem(Container newContainer)
        {
            CommonFunc.AddItem<Container>(_containers, newContainer);
        }

        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Container>(_containers, index);
        }

        public void ClearAll()
        {
            CommonFunc.DefaultInit(this._containers);
        }

        public IEnumerator GetEnumerator()
        {
            return _containers.GetEnumerator();
        }

        public int Length
        {
            get { return _containers.Length; }
        }

        public Container this[int index]
        {
            get { return _containers[index]; }
            set { _containers[index] = value; }
        }
    }
}
