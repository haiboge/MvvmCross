﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using System;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid;
using MvvmCross.Platform.Exceptions;

namespace MvvmCross.Binding.Droid.ResourceHelpers
{
    public class MvxAppResourceTypeFinder : IMvxAppResourceTypeFinder
    {
        public Type Find()
        {
            var setup = Mvx.Resolve<IMvxAndroidGlobals>();
            var resourceTypeName = setup.ExecutableNamespace + ".Resource";
            var resourceType = setup.ExecutableAssembly.GetType(resourceTypeName);
            if (resourceType == null)
                throw new MvxException("Unable to find resource type - " + resourceTypeName +
                                       ". Please check if your setup class is in your application's root namespace.");
            return resourceType;
        }
    }
}
