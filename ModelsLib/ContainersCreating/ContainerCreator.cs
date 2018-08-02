using ModelsLib.Collections;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ContainersCreating
{
    public abstract class ContainersCreator
    {
        //public Containers ss;
        private Container[] _containers;

        public Container[] containers
        {
            get { return _containers; }
        }
        public ContainersCreator()
        {
            this._containers = (Container[])Array.CreateInstance(typeof(Container), 0);
        }
        public abstract void AddItem(Container _newContainer);
        public abstract void RemoveItem(int _index);
        public abstract void ClearAll();
    }
}
