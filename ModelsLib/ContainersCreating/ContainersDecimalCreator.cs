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
    /// The ContainersDecimalCreator  class provides the  object an array of Containers<decimal>
    /// </summary>
    public class ContainersDecimalCreator : ContainersCreator
    {
        /// <summary>
        /// add new decimal-value Containers in Containers's array
        /// </summary>
        public override IContainers[] AddContainers()
        {
          return   CommonFunc.AddNewContainers(ref this._containersArr, new Containers<decimal>());
        }
    }
}
