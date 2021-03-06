// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames",
    Justification = "Project is open source, and anyone can modify and sign at their leisure when required")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "TRex.Extensions",
    Justification = "Namespace is meaningful and allows consuming developers to aovid bringing in extension methods they don't want")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments",
    Scope = "type", Target = "TRex.Metadata.MetadataAttribute",
    Justification = "Consuming developers should be able to choose between positional and named arguments, moving only to named arguments makes for unneeded verbosity when all arguments are provided")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments",
    Scope = "type", Target = "TRex.Metadata.TriggerAttribute",
    Justification = "Consuming developers should be able to choose between positional and named arguments, moving only to named arguments makes for unneeded verbosity when all arguments are provided")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed",
    Scope = "member", Target = "TRex.Metadata.MetadataAttribute.#.ctor(System.String,System.String,TRex.Metadata.VisibilityType)",
    Justification = "Providing ctor overload with all default arguments would be meaningless, but providing multiple overloads for all combinations would lead to ambiguity given 2 string arguments that could be passed all alone")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.ParameterExtensions.#SetVisibility(Swashbuckle.Swagger.Parameter,TRex.Metadata.VisibilityType)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.OperationExtensions.#SetVisibility(Swashbuckle.Swagger.Operation,TRex.Metadata.VisibilityType)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.SchemaExtensions.#SetVisibility(Swashbuckle.Swagger.Schema,TRex.Metadata.VisibilityType)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase",
    Scope = "member", Target = "QuickLearn.ApiApps.Metadata.TRexOperationFilter.#applyTriggerInfo(Swashbuckle.Swagger.Operation,System.Web.Http.Description.ApiDescription,Swashbuckle.Swagger.SchemaRegistry)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "TRex.Metadata",
    Justification = "Split the assembly to allow for sharing models between projects targeting different devices. Some items had to stay behind.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.SchemaExtensions.#SetCallbackUrl(Swashbuckle.Swagger.Schema)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#ValueTitle",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#ValueCollection",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#ValuePath",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicValuesModel.#OperationId",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-values extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.NotificationContentModel.#Description",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.NotificationContentModel.#Schema",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.SchemaModel.#Type",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.SchemaModel.#Ref",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-notification-content extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.OperationExtensions.#SetTrigger(Swashbuckle.Swagger.Operation,TRex.Metadata.BatchMode)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicSchemaModel.#OperationId",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-schema extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicSchemaModel.#ValuePath",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-schema extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.Extensions.OperationExtensions.#SetTrigger(Swashbuckle.Swagger.Operation,Swashbuckle.Swagger.SchemaRegistry,TRex.Metadata.TriggerAttribute)",
    Justification = "Designer needs it to be lowercase")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "TRex.Metadata.Models.DynamicSchemaModel.#Parameters",
    Justification = "Used by the swagger generator to emit JSON that is necessary to build the x-ms-dynamic-schema extension data for the designer.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "TRex.Metadata.PollingTriggerExtensions.#EventTriggered`2(System.Net.Http.HttpRequestMessage,!!1,System.TimeSpan,System.String,!!0)",
    Justification = "The response object is returned to the caller")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "TRex.Metadata.PollingTriggerExtensions.#EventWaitPoll`1(System.Net.Http.HttpRequestMessage,System.TimeSpan,System.String,!!0)",
    Justification = "The response object is returned to the caller")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0031:Use null propagation", Justification = "Suggested change would require executing expensive reflection method twice. Adding a separate null check after assignment may require more lines but is actually faster.", Scope = "member", Target = "~M:QuickLearn.ApiApps.Metadata.Extensions.ApiDescriptionExtensions.GetFirstOrDefaultCustomAttribute``1(System.Web.Http.Controllers.HttpActionDescriptor)~``0")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0031:Use null propagation", Justification = "Suggested change would require executing expensive reflection method twice. Adding a separate null check after assignment may require more lines but is actually faster.", Scope = "member", Target = "~M:QuickLearn.ApiApps.Metadata.Extensions.ApiDescriptionExtensions.GetFirstOrDefaultCustomAttribute``1(System.Web.Http.Controllers.HttpParameterDescriptor)~``0")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1812:AvoidUninstantiatedInternalClasses", Scope = "type", Target = "TRex.Metadata.TRexDocumentFilter",
    Justification = "Instantiated by Swashbuckle during post-processing of swagger metadata")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object,System.Object)", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.TRexSchemaFilter.#applySchemaLookupForDynamicModels(Swashbuckle.Swagger.Schema,Swashbuckle.Swagger.SchemaRegistry,System.Type)",
    Justification = "Refers to generated code")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "TRex.Metadata.DynamicModelBase.#TryGetMember(System.Dynamic.GetMemberBinder,System.Object&)",
    Justification = "Re-throwing exceptions would defeat the purpose implied by the 'Try' part of the method name, and violate expected behaviors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Scope = "member", Target = "QuickLearn.ApiApps.Metadata.TRexSchemaFilter.#applySchemaLookupForDynamicModels(Swashbuckle.Swagger.Schema,Swashbuckle.Swagger.SchemaRegistry,System.Type)",
    Justification = "Refers to generated code")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "TRex.Metadata.DynamicModelBase.#TrySetMember(System.Dynamic.SetMemberBinder,System.Object)",
    Justification = "Re-throwing exceptions would defeat the purpose implied by the 'Try' part of the method name, and violate expected behaviors")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "TRex.Metadata.PollingTriggerExtensions.#EventTriggered`2(System.Net.Http.HttpRequestMessage,!!1,System.String,!!0)",
    Justification = "The variable in question is returned to the caller and should not be disposed before being returned.")]

