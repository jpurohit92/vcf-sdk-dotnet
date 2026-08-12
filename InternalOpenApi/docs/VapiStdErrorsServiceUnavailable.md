# Vcenter.Automation.OpenApi.Model.VapiStdErrorsServiceUnavailable
The Vapi.Std.Errors.ServiceUnavailable error indicates that the resource is unavailable.    Examples:     - Attempt to invoke a operation when the server is too busy.     - Attempt to invoke a operation when the server is undergoing maintenance.     - An operation fails to contact VMware Tools running inside the virtual machine.       Counterexamples:     - A client provides an invalid service or operation identifier when invoking the operation using a dynamic interface (for example REST). The *Vapi.Std.Errors.OperationNotFound* error would be used instead.     - A client invokes the operation from the resource, but that resource has not been installed. The *Vapi.Std.Errors.OperationNotFound* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

