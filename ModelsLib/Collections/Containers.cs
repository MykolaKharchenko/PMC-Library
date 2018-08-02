using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib.Collections;

namespace ModelsLib
{
    public abstract class ContainersCreator : IEnumerable
    {
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
        //public abstract Container[] InitCollection();

        public IEnumerator GetEnumerator()
        {
            return containers.GetEnumerator();
        }

        public int Length
        {
            get { return containers.Length; }
        }

        public Container this[int index]
        {
            get { return containers[index]; }
            set { containers[index] = value; }
        }
        //public abstract int PropName { get; set; }
    }
    public class ContainersIntCreator : ContainersCreator
    {
        public override void AddItem(Container newContainer)
        {
            CommonFunc.AddItem<Container>(containers, newContainer);
        }

        public override void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Container>(containers, index);
        }

        public override void ClearAll()
        {
            CommonFunc.DefaultInit(this.containers);
        }
    }

    public class ContainersDecimalCreator : ContainersCreator
    {

        public override void AddItem(Container newContainer)
        {
            CommonFunc.AddItem<Container>(containers, newContainer);
        }

        public override void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Container>(containers, index);
        }

        public override void ClearAll()
        {
            CommonFunc.DefaultInit(this.containers);
        }
    }
    public class ContainersDoubleCreator : ContainersCreator
    {
        public override void AddItem(Container newContainer)
        {
            CommonFunc.AddItem<Container>(containers, newContainer);
        }

        public override void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Container>(containers, index);
        }

        public override void ClearAll()
        {
            CommonFunc.DefaultInit(this.containers);
        }
    }

    /*
    public abstract class IContainers
    {
    }
    public class Containers : IContainers
    {
        //public Containers()
        //{
        //    this._containers = (Container[])Array.CreateInstance(typeof(Container), 0);
        //}
    }    
    */
}






//abstract class Product                    // interfaces for containers
//class ConcreteProductA : Product          //  or only empty 
//class ConcreteProductB : Product          //

//abstract class Creator                    //
//class ConcreteCreatorA : Creator          //
//class ConcreteCreatorB : Creator          //