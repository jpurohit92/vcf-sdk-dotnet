# Vcenter.Automation.OpenApi.Model.VapiStdErrorsNotAllowedInCurrentState
The Vapi.Std.Errors.NotAllowedInCurrentState error indicates that the requested operation is not allowed with a resource or service in its current state. This could be because the operation is performing a configuration change that is not allowed in the current state or because operation itself is not allowed in the current state.    Examples:     - Trying to add a virtual device that cannot be hot plugged to a running virtual machine.     - Trying to upgrade the virtual hardware version for a suspended virtual machine.     - Trying to power off, reset, or suspend a virtual machine that is not powered on.       Counterexamples:     - Trying to power off a virtual machine that is in the process of being powered on. The *Vapi.Std.Errors.ResourceBusy* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

