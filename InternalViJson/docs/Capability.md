# Vcenter.ViJson.OpenApi.Model.Capability

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProvisioningSupported** | **bool** | Indicates whether or not the service instance supports provisioning.  For example, the *CloneVM* operation.  | 
**MultiHostSupported** | **bool** | Indicates whether or not the service instance supports multiple hosts.  | 
**UserShellAccessSupported** | **bool** | Flag indicating whether host user accounts should have the option to be granted shell access  | 
**SupportedEVCMode** | [**List&lt;EVCMode&gt;**](EVCMode.md) | All supported Enhanced VMotion Compatibility modes.  | [optional] 
**SupportedEVCGraphicsMode** | [**List&lt;FeatureEVCMode&gt;**](FeatureEVCMode.md) | All supported Enhanced VMotion Compatibility Graphics modes.  ***Since:*** vSphere API Release 7.0.1.0  | [optional] 
**NetworkBackupAndRestoreSupported** | **bool** | Indicates whether network backup and restore feature is supported.  | [optional] 
**FtDrsWithoutEvcSupported** | **bool** | Is DRS supported for Fault Tolerance VMs without enabling EVC.  | [optional] 
**HciWorkflowSupported** | **bool** | Specifies if the workflow for setting up a HCI cluster is supported.  | [optional] 
**ComputePolicyVersion** | **int** | Specifies the supported compute policy version.  | [optional] 
**ClusterPlacementSupported** | **bool** |  | [optional] 
**LifecycleManagementSupported** | **bool** | Specifies if lifecycle management of a Cluster is supported.  | [optional] 
**HostSeedingSupported** | **bool** | Specifies if host seeding for a cluster is supported.  ***Since:*** vSphere API Release 7.0.2.0  | [optional] 
**ScalableSharesSupported** | **bool** | Specifies if scalable shares for resource pools is supported.  | [optional] 
**HadcsSupported** | **bool** | Deprecated as of vSphere 9.0 with no replacement. In a future release of vSphere, the vCLS functionality will be disabled, vCLS system VMs will be deleted, and vCLS APIs will be removed.  Specifies if highly available distributed clustering service is supported.  ***Since:*** vSphere API Release 7.0.1.1  | [optional] 
**ConfigMgmtSupported** | **bool** | Specifies if desired configuration management platform is supported on the cluster.  ***Since:*** vSphere API Release 7.0.3.1  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

