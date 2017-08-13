// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using Microsoft.Web.Helpers;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("Microsoft.Web.Helpers")]
[assembly: AssemblyDescription("")]
[assembly: PreApplicationStartMethod(typeof(PreApplicationStartCode), "Start")]
[assembly: InternalsVisibleTo("Microsoft.Web.Helpers.Test")]
