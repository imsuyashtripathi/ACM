﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.bl
{
    public enum EntityState
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityState EntityState { get; set; }
        public bool IsNew { get; private set; }
        public bool HasChange { get; set; }
        public bool IsValid => Validate();
        public abstract bool Validate();
    }
}
