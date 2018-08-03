using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ContainersCreating
{    
    public class ContainersDecimalCreator : ContainersCreator
    {
        public override IContainers[] AddContainers()
        {
          return   CommonFunc.AddNewContainers(this.ContainersArr, new Containers<decimal>());

            this.AddContainers();
            //  ContainersArr.Add;
        }
    }
}
