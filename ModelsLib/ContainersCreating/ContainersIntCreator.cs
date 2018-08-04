using ModelsLib.Collections;
using ModelsLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLib.ContainersCreating
{
    /// <summary>
    /// The ContainersIntCreator  class provides the  object an array of Containers<int>
    /// </summary>
    public class ContainersIntCreator : ContainersCreator
    {
        /// <summary>
        /// add new int-value Containers in Containers's array
        /// </summary>
        public override IContainers[] AddContainers()
        {
            return CommonFunc.AddNewContainers(ref this._containersArr, new Containers<int?>());
        }
    }
}
