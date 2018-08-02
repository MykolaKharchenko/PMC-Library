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
        private Container[] containers;

        public Container[] _containers
        {
            get { return containers; }
        }

        public abstract void AddItem(Container _newContainer);
        public abstract void RemoveItem(int _index);
        public abstract void ClearAll();

        public abstract Container[] InitCollection();

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

        //public abstract int PropName { get; set; }
    }

    public class ContainersIntCreator : ContainersCreator
    {
        public override Container[] InitCollection()
        {
            return null;
        }


        public override void AddItem(Container newContainer)
        {
            CommonFunc.AddItem<Container>(_containers, newContainer);
        }

        public override void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Container>(_containers, index);
        }

        public override void ClearAll()
        {
            CommonFunc.DefaultInit(this._containers);
        }
    }

    public class ContainersDecimalCreator : ContainersCreator
    {
        public override Container[] InitCollection()
        {
            return base._containers;
        }

        public override void AddItem(Container newContainer)
        {
            CommonFunc.AddItem<Container>(_containers, newContainer);
        }

        public override void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Container>(_containers, index);
        }

        public override void ClearAll()
        {
            CommonFunc.DefaultInit(this._containers);
        }
    }
    public class ContainersDoubleCreator : ContainersCreator
    {
        public override Container[] InitCollection()
        {
            return base._containers;
        }
        public override void AddItem(Container newContainer)
        {
            CommonFunc.AddItem<Container>(_containers, newContainer);
        }

        public override void RemoveItem(int index)
        {
            CommonFunc.RemoveItem<Container>(_containers, index);
        }

        public override void ClearAll()
        {
            CommonFunc.DefaultInit(this._containers);
        }
    }

    public abstract class IContainers
    {
        void AddItem() { }
        void RemoveItem() { }
        void ClearAll() { }
    }

    public class Containers : IContainers
    {
        //public Containers()
        //{
        //    this._containers = (Container[])Array.CreateInstance(typeof(Container), 0);
        //}
    }
}






//abstract class Product                    // interfaces for containers
//class ConcreteProductA : Product          //  or only empty 
//class ConcreteProductB : Product          //

//abstract class Creator                    //
//class ConcreteCreatorA : Creator          //
//class ConcreteCreatorB : Creator          //