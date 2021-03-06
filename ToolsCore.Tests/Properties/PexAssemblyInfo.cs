using System.Globalization;
using System;
using System.Runtime.InteropServices;
using Microsoft.Pex.Framework.Suppression;
// <copyright file="PexAssemblyInfo.cs">Copyright ©  2021</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("ToolsCore")]
[assembly: PexInstrumentAssembly("ExControls")]
[assembly: PexInstrumentAssembly("Microsoft.CSharp")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "ExControls")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Microsoft.CSharp")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Drawing")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]
[assembly: PexInstrumentType("mscorlib", "System.Text.EncodingNLS")]
[assembly: PexSuppressUninstrumentedMethodFromType("System.Text.EncodingNLS")]
[assembly: PexInstrumentAssembly("System.Drawing")]
[assembly: PexInstrumentType(typeof(HandleRef))]
[assembly: PexInstrumentType(typeof(OperatingSystem))]
[assembly: PexInstrumentAssembly("System.Deployment")]
[assembly: PexInstrumentType(typeof(Enum))]
[assembly: PexInstrumentType("mscorlib", "System.Text.SBCSCodePageEncoding")]
[assembly: PexInstrumentType(typeof(DateTimeFormatInfo))]
[assembly: PexInstrumentType("mscorlib", "System.DateTimeParse")]
