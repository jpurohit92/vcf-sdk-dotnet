# Vcenter.ViJson.OpenApi.Model.VsanConfigInfoEx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether the VSAN service is enabled for the cluster.  | [optional] 
**DefaultConfig** | [**VsanClusterConfigInfoHostDefaultInfo**](VsanClusterConfigInfoHostDefaultInfo.md) | Default VSAN settings to use for hosts admitted to the cluster when the VSAN service is enabled.  If omitted, values will default as though the fields in the *VsanClusterConfigInfoHostDefaultInfo* have been omitted.  See also *VsanClusterConfigInfo.enabled*, *VsanClusterConfigInfoHostDefaultInfo*.  | [optional] 
**VsanEsaEnabled** | **bool** | Whether the vSAN ESA is enabled for vSAN cluster.  This can only be enabled when vSAN is enabled on the cluster.  ***Since:*** vSphere API Release 8.0.0.1  | [optional] 
**VsanCyberRecoveryEnabled** | **bool** | Whether vSAN Cyber Recovery is enabled.  Cyber Recovery has not been configured and is disabled when it is omitted.  ***Since:*** vSphere API Release 9.1.0.0  | [optional] 
**DataEfficiencyConfig** | [**VsanDataEfficiencyConfig**](VsanDataEfficiencyConfig.md) | The data efficiency configuration for vSAN.  | [optional] 
**ResyncIopsLimitConfig** | [**ResyncIopsInfo**](ResyncIopsInfo.md) | vSAN throttling IOPS limit configuration specification.  | [optional] 
**IscsiConfig** | [**VsanIscsiTargetServiceConfig**](VsanIscsiTargetServiceConfig.md) | vSAN iSCSI configuration.  | [optional] 
**DataEncryptionConfig** | [**VsanDataEncryptionConfig**](VsanDataEncryptionConfig.md) | The data encryption configuration for vSAN.  | [optional] 
**ExtendedConfig** | [**VsanExtendedConfig**](VsanExtendedConfig.md) | vSAN extended configurations.  | [optional] 
**DatastoreConfig** | [**VsanDatastoreConfig**](VsanDatastoreConfig.md) | vSAN datastore configuration.  | [optional] 
**PerfsvcConfig** | [**VsanPerfsvcConfig**](VsanPerfsvcConfig.md) | vSAN performance service configuration.  | [optional] 
**UnmapConfig** | [**VsanUnmapConfig**](VsanUnmapConfig.md) | SCSI unmap command configuration on vSAN.  | [optional] 
**VumConfig** | [**VsanVumConfig**](VsanVumConfig.md) | vSAN build recommendation engine configuration for this vSAN cluster.  Build recommendation engine would use it to generate different baselines for this vSAN cluster. See *VsanVumConfig*  | [optional] 
**FileServiceConfig** | [**VsanFileServiceConfig**](VsanFileServiceConfig.md) | vSAN file service configurations.  | [optional] 
**MetricsConfig** | [**VsanMetricsConfig**](VsanMetricsConfig.md) | vSAN metrics configuration for all monitor clients  | [optional] 
**RdmaConfig** | [**VsanRdmaConfig**](VsanRdmaConfig.md) | RDMA Spec for vSAN.  | [optional] 
**DataInTransitEncryptionConfig** | [**VsanDataInTransitEncryptionConfig**](VsanDataInTransitEncryptionConfig.md) | Data-in-transit encryption configuration for the vSAN cluster.  | [optional] 
**VsanHealthConfig** | [**VsanHealthConfigSpec**](VsanHealthConfigSpec.md) | vSAN Health configuration.  | [optional] 
**Mode** | **string** | Mode for vSAN.  See also *VsanMode_enum*.  | [optional] 
**VsanPMemConfig** | [**VimVsanVsanPMemConfig**](VimVsanVsanPMemConfig.md) | Deprecated as of vSphere 9.0 APIs with no replacement.  vSAN PMem configuration.  | [optional] 
**VsanEsaConfigInfo** | [**VsanEsaConfigInfo**](VsanEsaConfigInfo.md) | Configuration info for vSAN ESA.  | [optional] 
**XvcDatastoreConfig** | [**VsanXVCDatastoreConfig**](VsanXVCDatastoreConfig.md) | vSAN cross VC datastore configuration.  | [optional] 
**ServerClusterConfig** | [**VcRemoteVsanServerClusterConfig**](VcRemoteVsanServerClusterConfig.md) | Server cluster configuration for HCI Mesh.  | [optional] 
**DatastoreDefaultPolicySelectionConfig** | [**VsanDatastoreDefaultPolicySelectionConfig**](VsanDatastoreDefaultPolicySelectionConfig.md) | vSAN datastore default policy selection configurations.  Only available for vSAN ESA  | [optional] 
**SnapServiceConfig** | [**VsanSnapServiceConfig**](VsanSnapServiceConfig.md) | The configuration for vSAN Snapshot service.  The Snapshot service configuration will require specific User role and privileges. TODO: Update required privileges and the implementaiton to include the necessary validations.  ***Since:*** 8.0.0.4  | [optional] 
**DeconvergedNetConfig** | [**VsanDeconvergedNetConfig**](VsanDeconvergedNetConfig.md) | De-converged network configuration for vSAN.  | [optional] 
**SiteFaultDomainConfig** | [**VsanSiteFaultDomainConfig**](VsanSiteFaultDomainConfig.md) | Configuration of site fault domain for compute only cluster.  | [optional] 
**VbossClusterConfig** | [**VsanVbossClusterConfig**](VsanVbossClusterConfig.md) | The cluster level configuration of vSAN vBoss service.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

