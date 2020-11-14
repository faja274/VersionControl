﻿using gyak8.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak8.Entities
{
    public class IToyFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
