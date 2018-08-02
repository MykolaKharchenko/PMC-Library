using ModelsLib.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ContainersCreating
{
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
}
