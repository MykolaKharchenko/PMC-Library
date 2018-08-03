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

        // я не могу инкрементировать это значение((
        private IContainers[] _containersArr;

        public IContainers[] ContainersArr
        {
            get { return _containersArr; }
        }

        public ContainersCreator()
        {
            if (this._containersArr == null)
                _containersArr = (IContainers[])Array.CreateInstance(typeof(IContainers), 0);
            _containersArr = AddContainers();
        }

        //  single method for subcreators
        public abstract IContainers[] AddContainers();

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