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
    /// <summary>
    /// The ContainersCreator abstract class provides the  object  of an array of IContainers.
    /// </summary>
    public abstract class ContainersCreator
    {
        protected IContainers[] _containersArr;

        /// <summary>
        /// Containers's array 
        /// </summary>
        public IContainers[] ContainersArr
        {
            get { return _containersArr; }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public ContainersCreator()
        {
            if (this._containersArr == null)
                CommonFunc.DefaultInit(out _containersArr);
            _containersArr = AddContainers();
        }

        /// <summary>
        /// add new item in Containers's array (non-generic)
        /// </summary>
        public abstract IContainers[] AddContainers();

        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(ref _containersArr, index);
        }

        /// <summary>
        /// remove all items from current array of Containers's array 
        /// </summary>
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