﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace monitoR.Service.Service
{
    class AppService : ServiceControl
    {

        public bool Start(HostControl hostControl) {
            
            return true;
        }

        public bool Stop(HostControl hostControl) {
            return true;
        }
    }
}
