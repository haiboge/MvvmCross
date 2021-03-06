﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using MvvmCross.Platform.Core;

namespace MvvmCross.Test.Mocks.Dispatchers
{
    public class InlineMockMainThreadDispatcher
        : MvxMainThreadDispatcher, IMvxMainThreadDispatcher
    {
        public virtual bool RequestMainThreadAction(Action action, 
            bool maskExceptions = true)
        {
            action();
            return true;
        }
    }
}