# Vcenter.ViJson.OpenApi.Model.VSANVcSetPreferredFaultDomainRequestType
The parameters of *VimClusterVsanVcStretchedClusterSystem.VSANVcSetPreferredFaultDomain*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Target vSAN stretched cluster;  ***Required privileges:*** Host.Inventory.EditCluster  Refers instance of *ClusterComputeResource*.  | 
**PreferredFd** | **string** | The user friendly name of preferred Fault Domain;  | 
**WitnessHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | The witness host to apply preferred Fault Domain setting; if it is not specified, will take the in-use witness host configured at cluster side.  Refers instance of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

