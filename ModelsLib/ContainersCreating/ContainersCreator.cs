using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ContainersCreating
{
    public abstract class ContainersCreator //<T>
    {
        // containers's creator must prefer a collection (array) of containers
        private IContainers[] _containersArr;

        public IContainers[] ContainersArr
        {
            get { return _containersArr; }
        }

        public ContainersCreator()
        {
            this._containersArr = (IContainers[])Array.CreateInstance(typeof(IContainers), 0);
        }
        
        //  single method for subcreators
        public abstract void AddContainers(IContainers _newContainer);
        
        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(_containersArr, index);
        }

        public void ClearAll()
        {
            CommonFunc.DefaultInit(out _containersArr);
        }

        public IEnumerator GetEnumerator()
        {
            return ContainersArr.GetEnumerator();
        }

        public int Length
        {
            get { return ContainersArr.Length; }
        }

        public IContainers this[int index]
        {
            get { return ContainersArr[index]; }
            set { ContainersArr[index] = value; }
        }
    }
}