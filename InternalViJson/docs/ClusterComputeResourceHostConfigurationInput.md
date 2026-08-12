# Vcenter.ViJson.OpenApi.Model.ClusterComputeResourceHostConfigurationInput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Refers instance of *HostSystem*.  | 
**HostVmkNics** | [**List&lt;ClusterComputeResourceHostVmkNicInfo&gt;**](ClusterComputeResourceHostVmkNicInfo.md) |  | [optional] 
**AllowedInNonMaintenanceMode** | **bool** | To apply configuration on the host, the host is expected to be in maintenance mode.  This constraint can be relaxed by setting this flag to true.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

