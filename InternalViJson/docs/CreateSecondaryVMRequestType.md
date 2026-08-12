# Vcenter.ViJson.OpenApi.Model.CreateSecondaryVMRequestType
The parameters of *VirtualMachine.CreateSecondaryVM_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host where the secondary virtual machine is to be created and powered on. If no host is specified, a compatible host will be selected by the system. If a host cannot be found for the secondary or the specified host is not suitable, the secondary will not be created and a fault will be returned.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

