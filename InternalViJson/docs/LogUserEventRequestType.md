# Vcenter.ViJson.OpenApi.Model.LogUserEventRequestType
The parameters of *EventManager.LogUserEvent*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The entity against which the event is logged. The entity must be the root folder, a DataCenter, a VirtualMachine, a HostSystem, or a ComputeResource.  ***Required privileges:*** Global.LogEvent  Refers instance of *ManagedEntity*.  | 
**Msg** | **string** | The message to be logged.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

