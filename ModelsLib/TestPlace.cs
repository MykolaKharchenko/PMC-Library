using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLib.Collections;

namespace ModelsLib
{
    //abstract class Product                    // interfaces for containers
    //class ConcreteProductA : Product          //  or only empty 
    //class ConcreteProductB : Product          //

    //abstract class Creator                    //
    //class ConcreteCreatorA : Creator          //
    //class ConcreteCreatorB : Creator          //
    
    public abstract class CommonContainersCreator
    {
        public Container[] _containers;
        public abstract Container[] InitCollection();

        public abstract int PropName { get; set; }
    }

    public class ContainersCreator1 : CommonContainersCreator
    {
        public override Container[] InitCollection()
        {
            return null;  
        }
        public override int PropName { get; set; }
    }

    public class ContainersCreator2 : CommonContainersCreator
    {
        public override Container[] InitCollection()
        {
            return base._containers;
        }
        public override int PropName { get; set; }
    }

    public abstract class IContainers
    {

    }

    public class Containers : IContainers
    {
    }

    



}
