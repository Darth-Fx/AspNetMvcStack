// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.

[assembly: AssemblyTitle("System.Net.Http.Formatting")]
[assembly: AssemblyDescription("")]
#if !NETFX_CORE // GuidAttibute is not supported in portable libraries
[assembly: Guid("7fa1ae84-36e2-46b6-812c-c985a8e65e9a")]
[assembly: InternalsVisibleTo("System.Net.Http.Formatting.Test")]
[assembly: InternalsVisibleTo("System.Net.Http.Formatting.Test.Integration")]
#else
[assembly: InternalsVisibleTo("System.Net.Http.Formatting.NetCore.Test")]
#endif
