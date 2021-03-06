﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using Android.Views;
using MvvmCross.Platform;

namespace MvvmCross.Plugins.Color.Droid.BindingTargets
{
    [Preserve(AllMembers = true)]
    public class MvxViewBackgroundColorBinding
        : MvxViewColorBinding
    {
        public MvxViewBackgroundColorBinding(View view)
            : base(view)
        {
        }

        protected override void SetValueImpl(object target, object value)
        {
            var view = (View)target;
            view?.SetBackgroundColor((Android.Graphics.Color) value);
        }
    }
}
