using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ContainersCreating
{
    public class ContainersIntCreator : ContainersCreator  //<int>
    {
        public override void AddItem(IContainer newContainer)
        {
            CommonFunc.AddItem(ContainersArray, (Container<int>)newContainer);
        }    
    }
}
