﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNG.Interfaces.Output
{
    public interface IDataWriter
    {
        void Write(string path);
    }
}
