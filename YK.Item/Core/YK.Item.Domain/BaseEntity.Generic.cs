using System;
using System.Collections.Generic;
using System.Text;

namespace YK.Item.Domain
{
    public abstract class BaseEntity<TId> : BaseEntity
        where TId: struct, IEquatable<TId>
    {
        public TId Id { get; set; }
    }
}
