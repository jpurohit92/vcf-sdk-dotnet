# Vcenter.Automation.OpenApi.Model.VapiStdErrorsResourceInaccessible
The Vapi.Std.Errors.ResourceInaccessible error indicates that the operation could not be completed because an entity is not accessible.    Examples:     - Attempt to invoke some operation on a virtual machine when the virtual machine's configuration file is not accessible (for example due to a storage APD condition).       Counterexamples:     - Attempt to invoke some operation when the server is too busy. The *Vapi.Std.Errors.ServiceUnavailable* error would be used instead.     - Attempt to invoke some operation when the server is undergoing maintenance. The *Vapi.Std.Errors.ServiceUnavailable* error would be used instead.     - Some operation fails to contact VMware Tools running inside the virtual machine. The *Vapi.Std.Errors.ServiceUnavailable* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

