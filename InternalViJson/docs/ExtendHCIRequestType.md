# Vcenter.ViJson.OpenApi.Model.ExtendHCIRequestType
The parameters of *ClusterComputeResource.ExtendHCI_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostInputs** | [**List&lt;ClusterComputeResourceHostConfigurationInput&gt;**](ClusterComputeResourceHostConfigurationInput.md) | Inputs to configure specified set of hosts in the cluster. See *ClusterComputeResourceHostConfigurationInput* for details. Hosts in this list should be part of the cluster and should be in maintenance mode for them to be configured per specification. Hosts which were not configured due to not being in maintenance mode will be returned in *ClusterComputeResourceClusterConfigResult.failedHosts*. Specify *ClusterComputeResourceHostConfigurationInput.hostVmkNics* only if *dvsSetting* is set.  | [optional] 
**VSanConfigSpec** | [**SDDCBase**](SDDCBase.md) | Specification to configure vSAN on specified set of hosts. See vim.vsan.ReconfigSpec for details. This parameter should be specified only when vSan is enabled on the cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

