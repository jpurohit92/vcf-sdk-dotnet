# Vcenter.Automation.OpenApi.Model.VapiStdErrorsInvalidElementConfiguration
The Vapi.Std.Errors.InvalidElementConfiguration error indicates that an attempt to modify the configuration of an element or a group containing the element failed due to the configuraton of the element.    A typical case is when the operation is am attempt to change the group membership of the element fails, in which case a configuration change on the element may allow the group membership change to succeed.    Examples:     - Attempt to move a host with a fault tolerant virtual machine out of a cluster (i.e. make the host a standalone host).     - Attempt to remove a host from a DRS cluster without putting the host into maintenance mode.   

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

