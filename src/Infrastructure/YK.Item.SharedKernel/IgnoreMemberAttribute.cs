using System;
using System.Collections.Generic;
using System.Text;

namespace YK.Item.SharedKernel
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoreMemberAttribute : Attribute
    {
    }
}
