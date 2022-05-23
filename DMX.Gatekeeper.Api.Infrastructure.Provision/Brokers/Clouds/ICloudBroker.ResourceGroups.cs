﻿// ---------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ResourceManager.Fluent;

namespace DMX.Gatekeeper.Api.Infrastructure.Provision.Brokers.Clouds
{
    public partial interface ICloudBroker
    {
        ValueTask<IResourceGroup> CreateResourceGroupAsync(string resourceGroupName);

        ValueTask<bool> CheckResourceGroupExistsAsync(string resourceGroupName);

        ValueTask DeleteResourceGroupAsync(string resourceGroupName);
    }
}