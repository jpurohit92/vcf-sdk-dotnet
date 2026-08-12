# Vcenter.ViJson.OpenApi.Model.ValidateHCIConfigurationRequestType
The parameters of *ClusterComputeResource.ValidateHCIConfiguration*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HciConfigSpec** | [**ClusterComputeResourceHCIConfigSpec**](ClusterComputeResourceHCIConfigSpec.md) | The *ClusterComputeResourceHCIConfigSpec* to be used for validating the hosts. If not specified, the existing *ClusterComputeResourceHCIConfigInfo* of the cluster will be used.   Note:- This param must be omitted for post-configure validation.  | [optional] 
**Hosts** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The set of hosts to be validated. If not specified, the set of existing hosts in the cluster will be used.   Note:- This param must be omitted for post-configure validation.  Refers instances of *HostSystem*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

