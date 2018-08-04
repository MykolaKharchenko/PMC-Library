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
    /// <summary>
    /// The Container<T> class provides the  object  of an Container's array.
    /// </summary>
    public class Containers<T> : IContainers
    {
        /// <summary>
        /// Container's array
        /// </summary>
        public Container<T>[] _containers;
        
        /// <summary>
        /// default constructor
        /// </summary>
        public Containers()
        {
            CommonFunc.DefaultInit(out _containers);
        }

        /// <summary>
        /// constructor for many members(Container)
        /// </summary>
        public Containers(params Container<T>[] _collection)
        {
            Container<T>[] tempContainers = new Container<T>[_collection.Length];
            for (int i = 0; i < _collection.Length; i++)
                tempContainers[i] = _collection[i];
            _containers = tempContainers;
        }

        /// <summary>
        /// add new item in current array of Container's array
        /// </summary>
        public void AddItem(Container<T> newContainer)
        {
            CommonFunc.AddItem(ref _containers, newContainer);
        }

        /// <summary>
        /// remove item from current array of Container's array
        /// </summary>
        public void RemoveItem(int index)
        {
            CommonFunc.RemoveItem(ref _containers, index);
        }

        /// <summary>
        /// remove all items from current Container's array
        /// </summary>
        public void ClearAll()
        {
            CommonFunc.DefaultInit(out _containers);
        }
        
        public IEnumerator GetEnumerator()
        {
            return _containers.GetEnumerator();
        }

        public int Length
        {
            get { return _containers.Length; }
        }

        public Container<T> this[int index]
        {
            get { return _containers[index]; }
            set { _containers[index] = value; }
        }
    }
}
