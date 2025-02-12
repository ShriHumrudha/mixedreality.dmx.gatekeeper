﻿// ---------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------

using System;

namespace DMX.Gatekeeper.Api.Models.Labs
{
    public class LabDevice
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public LabDeviceType Type { get; set; }
        public LabDeviceStatus Status { get; set; }
        public LabDeviceCategory Category { get; set; }
    }
}
