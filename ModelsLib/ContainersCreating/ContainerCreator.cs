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
        private IContainer[] _containerArr;

        public IContainer[] ContainersArray
        {
            get { return _containerArr; }
        }
        public ContainersCreator()
        {
            this._containerArr = (IContainer[])Array.CreateInstance(typeof(IContainer), 0);
        }
    
        public abstract void AddItem(IContainer _newContainer);
    }
}