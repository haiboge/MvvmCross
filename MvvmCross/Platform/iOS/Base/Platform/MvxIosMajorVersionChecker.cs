﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MS-PL license.
// See the LICENSE file in the project root for more information.

using MvvmCross.Platform.Logging;

namespace MvvmCross.Platform.iOS.Platform
{
    public class MvxIosMajorVersionChecker
    {
        public bool IsVersionOrHigher { get; private set; }

        public MvxIosMajorVersionChecker(int major, bool defaultValue = true)
        {
            IsVersionOrHigher = ReadIsIosVersionOrHigher(major, defaultValue);
        }

        private static bool ReadIsIosVersionOrHigher(int target, bool defaultValue)
        {
            IMvxIosSystem touchSystem;
            Mvx.TryResolve<IMvxIosSystem>(out touchSystem);
            if (touchSystem == null)
            {
                MvxLog.Instance.Warn("IMvxIosSystem not found - so assuming we {1} on iOS {0} or later", target, defaultValue ? "are" : "are not");
                return defaultValue;
            }

            return touchSystem.Version.Major >= target;
        }
    }
}
