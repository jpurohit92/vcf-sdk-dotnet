# Vcenter.Automation.OpenApi.Model.VapiStdErrorsResourceInUse
The Vapi.Std.Errors.ResourceInUse error indicates that the operation could not be completed because a resource is in use.    Examples:     - Trying to remove a VMFS datastore when the is a virtual machine registered on any host attached to the datastore.     - Trying to add a virtual switch if the physical network adapter being bridged is already in use.       Counterexamples:     - Trying to power off a virtual machine that is in the process of being powered on. The *Vapi.Std.Errors.ResourceBusy* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

