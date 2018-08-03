using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ContainersCreating
{
    public class ContainersDoubleCreator : ContainersCreator
    {
        public override void AddItem(IContainer newContainer)
        {
            CommonFunc.AddItem(ContainersArray, (Container<double>)newContainer);
        }
    }
}
