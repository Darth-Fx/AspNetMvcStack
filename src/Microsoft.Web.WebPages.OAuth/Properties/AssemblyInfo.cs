// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;

[assembly: AssemblyTitle("Microsoft.Web.WebPages.OAuth")]
[assembly: AssemblyDescription("")]

[assembly: InternalsVisibleTo("Microsoft.Web.WebPages.OAuth.Test")]
[assembly: PreApplicationStartMethod(typeof(Microsoft.Web.WebPages.OAuth.PreApplicationStartCode), "Start")]
