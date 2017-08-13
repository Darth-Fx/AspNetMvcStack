// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.WebPages;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("System.Web.WebPages")]
[assembly: AssemblyDescription("")]
[assembly: InternalsVisibleTo("System.Web.Mvc")]
[assembly: InternalsVisibleTo("System.Web.Helpers")]
[assembly: InternalsVisibleTo("System.Web.WebPages.Test")]
[assembly: InternalsVisibleTo("System.Web.Helpers.Test")]
[assembly: InternalsVisibleTo("System.Web.WebPages.Administration.Test")]
[assembly: PreApplicationStartMethod(typeof(PreApplicationStartCode), "Start")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "System.Web.Helpers", Justification = "Namespace has more types in System.Web.Helpers.dll.")]
