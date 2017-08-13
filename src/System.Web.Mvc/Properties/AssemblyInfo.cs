// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Web.Mvc;

[assembly: AssemblyTitle("System.Web.Mvc.dll")]
[assembly: AssemblyDescription("System.Web.Mvc.dll")]
[assembly: Guid("4b5f4208-c6b0-4c37-9a41-63325ffa52ad")]

[assembly: InternalsVisibleTo("System.Web.Mvc.Test")]
[assembly: PreApplicationStartMethod(typeof(PreApplicationStartCode), "Start")]
[assembly: TypeForwardedTo(typeof(TagBuilder))]
[assembly: TypeForwardedTo(typeof(TagRenderMode))]
[assembly: TypeForwardedTo(typeof(HttpAntiForgeryException))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationEqualToRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRangeRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRegexRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRemoteRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRequiredRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationRule))]
[assembly: TypeForwardedTo(typeof(ModelClientValidationStringLengthRule))]
