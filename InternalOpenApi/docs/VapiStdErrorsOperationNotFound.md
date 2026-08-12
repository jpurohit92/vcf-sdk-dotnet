# Vcenter.Automation.OpenApi.Model.VapiStdErrorsOperationNotFound
The Vapi.Std.Errors.OperationNotFound error indicates that the operation specified in the request could not be found.    Every API request specifies a service identifier and an operation identifier along with the parameters. If the API infrastructure is unable to find the requested resource or operation it reports this error.    This error can be reported by the API infrastructure for any operation, but it is specific to the API infrastructure, and should never be reported by the implementation of any operation.    Examples:     - A client provides an invalid service or operation identifier when invoking the operation using a dynamic interface (for example REST).     - A client invokes the operation from a resource, but that resource has not been installed.       Counterexamples:     - A client invokes a task scheduling operation, but provides an invalid service identifier or operation identifier. The *Vapi.Std.Errors.NotFound* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

