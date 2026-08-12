# Vcenter.ViJson.OpenApi.Model.VmWwnConflict

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Property** | **string** | Path of the property in configSpec that has an invalid value.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine that is using the same WWN.  Refers instance of *VirtualMachine*.  | [optional] 
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host that is using the same WWN.  Refers instance of *HostSystem*.  | [optional] 
**Name** | **string** | The name of the virtual machine/host that is using the same WWN.  | [optional] 
**Wwn** | **long** | The WWN that is in conflict.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

