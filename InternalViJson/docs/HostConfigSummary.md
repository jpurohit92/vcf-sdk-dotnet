# Vcenter.ViJson.OpenApi.Model.HostConfigSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the host.  | 
**Port** | **int** | The port number.  | 
**SslThumbprint** | **string** | The SSL thumbprint of the host, if known.  | [optional] 
**SslCertificate** | **string** | The SSL certificate of the host, if known.  Note: *HostConfigSummary.sslThumbprint* and *HostConfigSummary.sslCertificate* parameters are mutually exclusive, and should never be used simultaneously.  ***Since:*** vSphere API Release 9.0.0.0  | [optional] 
**Product** | [**AboutInfo**](AboutInfo.md) | Information about the software running on the host, if known.  The current supported hosts are ESX Server 2.0.1 (and later) and VMware Server 2.0.0 (and later).  | [optional] 
**VmotionEnabled** | **bool** | The flag to indicate whether or not VMotion is enabled on this host.  | 
**FaultToleranceEnabled** | **bool** | The flag to indicate whether or not Fault Tolerance logging is enabled on this host.  | 
**FeatureVersion** | [**List&lt;HostFeatureVersionInfo&gt;**](HostFeatureVersionInfo.md) | List of feature-specific version information.  Each element refers to the version information for a specific feature.  | [optional] 
**AgentVmDatastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Datastore used to deploy Agent VMs on for this host.  Refers instance of *Datastore*.  | [optional] 
**AgentVmNetwork** | [**ManagedObjectReference**](ManagedObjectReference.md) | Management network for Agent VMs.  Refers instance of *Network*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

