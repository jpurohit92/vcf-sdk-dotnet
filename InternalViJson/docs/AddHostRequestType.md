# Vcenter.ViJson.OpenApi.Model.AddHostRequestType
The parameters of *ClusterComputeResource.AddHost_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Spec** | [**HostConnectSpec**](HostConnectSpec.md) | Specifies the parameters needed to add a single host.  | 
**AsConnected** | **bool** | Flag to specify whether or not the host should be connected immediately after it is added. The host will not be added if a connection attempt is made and fails.  | 
**ResourcePool** | [**ManagedObjectReference**](ManagedObjectReference.md) | the resource pool for the root resource pool from the host.  ***Required privileges:*** Resource.AssignVMToPool  Refers instance of *ResourcePool*.  | [optional] 
**License** | **string** | Provide a licenseKey or licenseKeyType. See *LicenseManager*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

