﻿using ModelsLib.Collections;
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
        public override void AddContainers(IContainers newContainer)
        {
            CommonFunc.AddNewContainers(this.ContainersArr, new Containers<decimal>());
        }
    }
}
