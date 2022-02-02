﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace CarOne
{
    using System.Composition;
    using Garage;

    [Export(typeof(Car))]
    [ExportMetadata("Year", 2016)]
    public class FirstCar : Car
    {
    }
}
