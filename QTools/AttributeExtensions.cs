﻿using System;
using System.Reflection;

namespace QTools
{
    public static class AttributeExtensions
    {
        public static bool HasAttribute<T>(this MemberInfo info) where T : Attribute => info.GetCustomAttribute<T>() != null;
    }
}
