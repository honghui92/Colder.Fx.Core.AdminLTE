﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Coldairarrow.Util
{
    public static partial class Extention
    {
        /// <summary>
        /// 拓展DbContext非泛型Set
        /// </summary>
        /// <param name="context">上下文</param>
        /// <param name="entityType">实体类型</param>
        /// <returns></returns>
        public static DbSet<object> Set(this DbContext context, Type entityType)
        {
            return (DbSet<object>)context.GetType().GetMethod("Set").MakeGenericMethod(entityType).Invoke(context, null);
        }
    }
}
