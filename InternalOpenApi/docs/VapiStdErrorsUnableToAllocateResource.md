# Vcenter.Automation.OpenApi.Model.VapiStdErrorsUnableToAllocateResource
The Vapi.Std.Errors.UnableToAllocateResource error indicates that the operation failed because it was unable to allocate or acquire a required resource.    Examples:     - Trying to power on a virtual machine when there are not enough licenses to do so.     - Trying to power on a virtual machine that would violate a resource usage policy.       Counterexamples:     - Trying to power off a virtual machine that is in the process of being powered on. A *Vapi.Std.Errors.ResourceBusy* error would be used instead.     - Trying to remove a VMFS datastore when the is a virtual machine registered on any host attached to the datastore. The *Vapi.Std.Errors.ResourceInUse* error would be used instead.     - Trying to add a virtual switch if the physical network adapter being bridged is already in use. The *Vapi.Std.Errors.ResourceInUse* error would be used instead.     - Attempt to invoke some operation on a virtual machine when the virtual machine's configuration file is not accessible (for example due to a storage APD condition). The *Vapi.Std.Errors.ResourceInaccessible* error would be used instead.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

