using System;
using System.Collections.Generic;
using System.Text;

namespace YK.Item.SharedKernel
{
    public abstract class BaseEntity
    {
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
