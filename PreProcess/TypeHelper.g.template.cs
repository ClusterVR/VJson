//
// Copyright (c) 2019- yutopp (yutopp@gmail.com)
//
// Distributed under the Boost Software License, Version 1.0. (See accompanying
// file LICENSE_1_0.txt or copy at  https://www.boost.org/LICENSE_1_0.txt)
//

// THIS FILE IS AUTOMATICALLY GENERATED from TypeHelper.g.template.cs

using System;
using System.Collections.Generic;

namespace VJson
{
    static partial class TypeHelper
    {
$body
        public static Func<object, object> GetConverter(Type fromTy, Type toTy)
        {
            Dictionary<Type, Func<object, object>> conv;
            if (_convTable.TryGetValue(fromTy, out conv))
            {
                Func<object, object> convFunc;
                if (conv.TryGetValue(toTy, out convFunc))
                {
                    return convFunc;
                }
            }

            return null;
        }
    }
}