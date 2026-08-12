# Vcenter.ViJson.OpenApi.Model.VmDasUpdateErrorEvent
The event records that an error occurred when updating the HA agents with the current state of the virtual machine.  If this occurs during a powerOn operation, the virtual machine will not be failed over in the event of a host failure. If it occurs during a powerOff, the virtual machine will be automatically powered on if the host it was last running on crashes. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Template** | **bool** | Indicates whether or not the virtual machine is marked as a template.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

