# Vcenter.ViJson.OpenApi.Model.VsanClusterReconfigureFsDomainRequestType
The parameters of *VsanFileServiceSystem.VsanClusterReconfigureFsDomain*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainUuid** | **string** | The UUID of the domain to be reconfigured.  | 
**DomainConfig** | [**VsanFileServiceDomainConfig**](VsanFileServiceDomainConfig.md) | New configuration of the domain. Only set the fields that require reconfiguration, and leave others unset.  | 
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | The target cluster. Ignored when called on ESXi hosts.  ***Required privileges:*** Host.Config.Storage  Refers instance of *ClusterComputeResource*.  | [optional] 
**DeleteDomainConfigFields** | **List&lt;string&gt;** | The domain config fields to be deleted. For example to remove directoryServerConfig from the domainConfig provide \\[\&quot;directoryServerConfig\&quot;\\] here and keep the same unset in provided domainConfig. Do note removing directoryServerConfig is only allowed when there are no active shares. Here is the list of currently supported field: - directoryServerConfig since 7.0U1 - directoryServerConfig.preferredADServers   since 8.0U1     Providing any other value here will cause InvalidArgumentError fault.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

