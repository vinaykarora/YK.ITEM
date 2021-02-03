using System;
using System.Collections.Generic;
using System.Text;

namespace YK.Item.SharedKernel
{
    public abstract class BaseEntity<TId> : BaseEntity
        where TId: struct, IEquatable<TId>
    {
        public TId Id { get; set; }
    }
}
