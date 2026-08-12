# Vcenter.ViJson.OpenApi.Model.ClusterHostPowerAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the action.  This is encoded to differentiate between different types of actions aimed at achieving different goals.  | 
**Target** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target object on which this action will be applied.  For instance, a migration action will have a virtual machine as its target object, while a host power action will have a host as its target action.  | [optional] 
**OperationType** | **HostPowerOperationTypeEnum** | Specify whether the action is power on or power off  | 
**PowerConsumptionWatt** | **int** | Estimated power consumption of the host.  In case of power-on, this is the projected increase in the cluster&#39;s power consumption. In case of power off, this is the projected decrease in the cluster&#39;s power consumption  | [optional] 
**CpuCapacityMHz** | **int** | CPU capacity of the host in units of MHz.  In case of power-on action, this is the projected increase in the cluster&#39;s CPU capacity. In case of power off, this is the projected decrease in the cluster&#39;s CPU capacity.  | [optional] 
**MemCapacityMB** | **int** | Memory capacity of the host in units of MM.  In case of power-on action, this is the projected increase in the cluster&#39;s memory capacity. In case of power off, this is the projected decrease in the cluster&#39;s memory capacity.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

