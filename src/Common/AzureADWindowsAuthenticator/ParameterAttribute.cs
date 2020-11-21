﻿/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License.
 */

using System;

namespace MsalAuthenticator
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class ParameterAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  https://go.microsoft.com/fwlink/?LinkId=85236
        public string Name { get; }

        public ParameterAttribute(string name) => this.Name = name;

        public bool Mandatory { get; set; }
    }
}
