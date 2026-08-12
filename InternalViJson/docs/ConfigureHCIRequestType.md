# Vcenter.ViJson.OpenApi.Model.ConfigureHCIRequestType
The parameters of *ClusterComputeResource.ConfigureHCI_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterSpec** | [**ClusterComputeResourceHCIConfigSpec**](ClusterComputeResourceHCIConfigSpec.md) | Specification to configure the cluster, see *ClusterComputeResourceHCIConfigSpec* for details. The *DistributedVirtualSwitch* and *DistributedVirtualPortgroup* objects contained within the specification must be in the same datacenter as the cluster. Specify *ClusterComputeResourceHCIConfigSpec.vSanConfigSpec* only when vSan is enabled on the cluster.  | 
**HostInputs** | [**List&lt;ClusterComputeResourceHostConfigurationInput&gt;**](ClusterComputeResourceHostConfigurationInput.md) | Inputs to configure each host in the cluster, see *ClusterComputeResourceHostConfigurationInput* for details. Hosts in this list should be part of the cluster and should be in maintenance mode for them to be configured per specification. If this parameter is not specified, the API operates on all the hosts in the cluster. Hosts which were not configured due to not being in maintenance mode will be returned in *ClusterComputeResourceClusterConfigResult.failedHosts*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

