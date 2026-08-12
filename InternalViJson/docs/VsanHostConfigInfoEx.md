# Vcenter.ViJson.OpenApi.Model.VsanHostConfigInfoEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether the VSAN service is currently enabled on this host.  | [optional] 
**HostSystem** | [**ManagedObjectReference**](ManagedObjectReference.md) | The *HostSystem* for this host.  This argument is required when this configuration is specified as an input to VC-level APIs. When this configuration is specified to a host-level direct API, this argument may be omitted.  See also *ComputeResource.ReconfigureComputeResource_Task*, *HostVsanSystem.UpdateVsan_Task*.  Refers instance of *HostSystem*.  | [optional] 
**ClusterInfo** | [**VsanHostConfigInfoClusterInfo**](VsanHostConfigInfoClusterInfo.md) | The VSAN service cluster configuration for this host.  | [optional] 
**StorageInfo** | [**VsanHostConfigInfoStorageInfo**](VsanHostConfigInfoStorageInfo.md) | The VSAN storage configuration for this host.  VSAN storage configuration settings are independent of the current value of *VsanHostConfigInfo.enabled*.  | [optional] 
**NetworkInfo** | [**VsanHostConfigInfoNetworkInfo**](VsanHostConfigInfoNetworkInfo.md) | The VSAN network configuration for this host.  VSAN network configuration settings are independent of the current value of *VsanHostConfigInfo.enabled*.  | [optional] 
**FaultDomainInfo** | [**VsanHostFaultDomainInfo**](VsanHostFaultDomainInfo.md) | The VSAN fault domain configuration for this host.  VSAN host fault domain settings are independent of the current value of *VsanHostConfigInfo.enabled*.  | [optional] 
**VsanEsaEnabled** | **bool** | Whether the vSAN ESA is enabled on this host.  This can only be enabled when vSAN is enabled on this host.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**VsanCyberRecoveryEnabled** | **bool** | Whether the vSAN Cyber Recovery is enabled on this host.  This can only be enabled when vSAN ESA is enabled on this host.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**EncryptionInfo** | [**VsanHostEncryptionInfo**](VsanHostEncryptionInfo.md) | Encryption configuration.  | [optional] 
**DataEfficiencyInfo** | [**VsanDataEfficiencyConfig**](VsanDataEfficiencyConfig.md) | Data efficiency configuration.  | [optional] 
**ResyncIopsLimitInfo** | [**ResyncIopsInfo**](ResyncIopsInfo.md) | Resync IOPS limit configuration in Mbps.  The value should be between 0 and 512.  | [optional] 
**ExtendedConfig** | [**VsanExtendedConfig**](VsanExtendedConfig.md) | vSAN Extended configurations.  | [optional] 
**DatastoreInfo** | [**VsanDatastoreConfig**](VsanDatastoreConfig.md) | Datastore configuration.  | [optional] 
**UnmapConfig** | [**VsanUnmapConfig**](VsanUnmapConfig.md) | SCSI unmap command configuration on vSAN.  | [optional] 
**WitnessHostConfig** | [**List&lt;VsanWitnessHostConfig&gt;**](VsanWitnessHostConfig.md) | Witness host configuration, available only when host works as witness node in vSAN stretched cluster, otherwise this field will be omitted.  | [optional] 
**InternalExtendedConfig** | [**VsanInternalExtendedConfig**](VsanInternalExtendedConfig.md) | vSAN host-level extended configurations.  | [optional] 
**MetricsConfig** | [**VsanMetricsConfig**](VsanMetricsConfig.md) | vSAN metric configurations for all monitor clients.  | [optional] 
**UnicastConfig** | [**VsanHostServerClusterUnicastConfig**](VsanHostServerClusterUnicastConfig.md) | Unicast configuration.  It is used for remote unicast agent operations. The remote unicast agent need to be set because when user mounts remote vSAN datastore, client cluster needs to access the objects on remote clusters.  | [optional] 
**RdmaConfig** | [**VsanRdmaConfig**](VsanRdmaConfig.md) | The RDMA configuration for vSAN.  | [optional] 
**DataInTransitEncryptionInfo** | [**VsanInTransitEncryptionInfo**](VsanInTransitEncryptionInfo.md) | vSAN configuration for data-in-transit encryption.  | [optional] 
**Mode** | **string** | Mode for vSAN.  See also *VsanMode_enum*.  | [optional] 
**ServerClusterConfigs** | [**List&lt;RemoteVsanServerClusterConfig&gt;**](RemoteVsanServerClusterConfig.md) | Server cluster configurations for HCI Mesh server clusters.  | [optional] 
**SnapServiceConfig** | [**VsanSnapServiceConfig**](VsanSnapServiceConfig.md) | The Snapshot Service configuration for vSAN.  ***Since:*** 8.0.0.4  | [optional] 
**DeconvergedNetConfig** | [**VsanDeconvergedNetConfig**](VsanDeconvergedNetConfig.md) | De-converged network configuration for vSAN.  | [optional] 
**RemoteDITInfos** | [**List&lt;VsanInTransitEncryptionInfo&gt;**](VsanInTransitEncryptionInfo.md) | vSAN configuration for data-in-transit encryption between client and server cluster.  | [optional] 
**ClientUnicastConfig** | [**VsanHostClientClusterUnicastConfig**](VsanHostClientClusterUnicastConfig.md) | Unicast configuration for server cluster members, which is used for remote unicast agent operations.  The client unicast agent needs to be set to support remote DIT between client and server cluster. When the client cluster mounts a remote datastore, its unicast config needs to be pushed to server hosts.  | [optional] 
**SiteTakeoverConfig** | [**VsanSiteTakeoverConfig**](VsanSiteTakeoverConfig.md) | The site takeover configuration for a host.  Only applicable when the cluster is configured as stretched cluster.  | [optional] 
**VbossHostConfig** | [**VsanVbossHostConfig**](VsanVbossHostConfig.md) | The host level configuration of vSAN vBoss service.  | [optional] 
**AutoRAIDConfig** | [**VsanAutoRAIDConfig**](VsanAutoRAIDConfig.md) | vSAN auto RAID configuration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

