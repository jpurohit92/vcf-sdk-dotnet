# Vcenter.Automation.OpenApi.Model.VapiStdErrorsUnexpectedInput
The Vapi.Std.Errors.UnexpectedInput error indicates that the request contained a parameter or property whose name is not known by the server.    Every operation expects parameters with known names. Some of those parameters may be (or contain) schemas, and the operation expects those schemas to contain properties with known names. If the operation receives parameters or properties with names that is does not expect, this error may be reported.    This error can be reported by the API infrastructure for any operation, but it is specific to the API infrastructure, and should never be reported by the implementation of any operation.    Examples:     - A client using stubs generated from the interface specification for version2 of a resource invokes the operation passing one or more parameters that were added in version2, but they are communicating with a server that only supports version1 of the resource.     - A client provides an unexpected parameter or property name when invoking the operation using a dynamic interface (for example REST).   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

