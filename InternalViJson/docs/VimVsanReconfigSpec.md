# Vcenter.ViJson.OpenApi.Model.VimVsanReconfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VsanClusterConfig** | [**VsanClusterConfigInfo**](VsanClusterConfigInfo.md) | vSAN configuration, includes default settings for hosts.  | [optional] 
**DataEfficiencyConfig** | [**VsanDataEfficiencyConfig**](VsanDataEfficiencyConfig.md) | The data efficiency configuration for vSAN.  vSAN 6.2 accomplishes data efficiency by deduplication and compression, which will be enabled or disabled together.  | [optional] 
**DiskMappingSpec** | [**VimClusterVsanDiskMappingsConfigSpec**](VimClusterVsanDiskMappingsConfigSpec.md) | vSAN disk group configuration specification.  | [optional] 
**FaultDomainsSpec** | [**VimClusterVsanFaultDomainsConfigSpec**](VimClusterVsanFaultDomainsConfigSpec.md) | Spec for configuring the fault domains.  It includes a list of *VimClusterVsanFaultDomainSpec* and a *VimClusterVsanWitnessSpec*. If *VimClusterVsanWitnessSpec* is specified which indicates it a stretched cluster, the fault domain list needs to include exactly two fault domain items.  | [optional] 
**Modify** | **bool** | Flag to specify whether the specification (\&quot;spec\&quot;) should be applied incrementally.  If \&quot;modify\&quot; is false and the operation succeeds, then the configuration of the vSAN cluster matches the specification exactly; in this case any unset portions of the specification will result in unset or default portions of the configuration.  | 
**AllowReducedRedundancy** | **bool** | This optional parameter is applicable to certain vSAN cluster reconfigure operations that need to migrate data across cluster for changing vSAN disk format.  In vSAN version 6.2, enable or disable deduplication and compression in a cluster is such kind of operation. The default value &#39;false&#39; will instruct the data migration process to move all the storage object data in the host under processing to other hosts to ensure the data stays fully protected; while the value &#39;true&#39; may make the process move less data for just ensuring storage object accessibility, and some objects will be kept at \&quot;reduced redundancy\&quot; state, i.e., at a higher risk in case of a hardware failure during the migration process. However, value &#39;true&#39; is useful and even the only option when cluster does not have enough host or free storage to ensure the data stays fully protected during data migration. See *ensureObjectAccessibility* and *evacuateAllData*.  | [optional] 
**ResyncIopsLimitConfig** | [**ResyncIopsInfo**](ResyncIopsInfo.md) | vSAN throttling IOPS limit configuration specification.  | [optional] 
**IscsiSpec** | [**VsanIscsiTargetServiceSpec**](VsanIscsiTargetServiceSpec.md) | vSAN iSCSI configuration.  | [optional] 
**DataEncryptionConfig** | [**VsanDataEncryptionConfig**](VsanDataEncryptionConfig.md) | The data encryption configuration for vSAN.  | [optional] 
**ExtendedConfig** | [**VsanExtendedConfig**](VsanExtendedConfig.md) | vSAN extended configurations.  | [optional] 
**DatastoreConfig** | [**VsanDatastoreConfig**](VsanDatastoreConfig.md) | vSAN datastore configuration.  | [optional] 
**PerfsvcConfig** | [**VsanPerfsvcConfig**](VsanPerfsvcConfig.md) | vSAN performance service configuration.  | [optional] 
**UnmapConfig** | [**VsanUnmapConfig**](VsanUnmapConfig.md) | SCSI unmap command configuration on vSAN.  | [optional] 
**VumConfig** | [**VsanVumConfig**](VsanVumConfig.md) | vSAN build recommendation engine configuration for this vSAN cluster.  Build recommendation engine would use it to generate different baselines for this vSAN cluster. See *VsanVumConfig*  | [optional] 
**MetricsConfig** | [**VsanMetricsConfig**](VsanMetricsConfig.md) | vSAN metrics configuration for all monitor clients  | [optional] 
**FileServiceConfig** | [**VsanFileServiceConfig**](VsanFileServiceConfig.md) | vSAN file service configurations.  | [optional] 
**RdmaConfig** | [**VsanRdmaConfig**](VsanRdmaConfig.md) | RDMA Spec for vSAN.  | [optional] 
**DataInTransitEncryptionConfig** | [**VsanDataInTransitEncryptionConfig**](VsanDataInTransitEncryptionConfig.md) | vSAN configuration for data-in-transit encryption.  | [optional] 
**Mode** | **string** | Mode for vSAN.  See also *VsanMode_enum*.  | [optional] 
**VsanHealthConfig** | [**VsanHealthConfigSpec**](VsanHealthConfigSpec.md) | vSAN Health configuration.  | [optional] 
**VsanEsaConfig** | [**VsanEsaConfig**](VsanEsaConfig.md) | Configurations for vSAN ESA.  | [optional] 
**XvcDatastoreConfig** | [**VsanXVCDatastoreConfig**](VsanXVCDatastoreConfig.md) | vSAN cross VC datastore configuration.  | [optional] 
**ServerClusterConfig** | [**VcRemoteVsanServerClusterConfig**](VcRemoteVsanServerClusterConfig.md) | Server cluster configuration for HCI Mesh.  | [optional] 
**SnapServiceConfig** | [**VsanSnapServiceConfig**](VsanSnapServiceConfig.md) | The configuration for vSAN Snapshot service.  The Snapshot service configuration will require specific User role and privileges. TODO: Update required privileges and the implementaiton to include the necessary validations.  ***Since:*** 8.0.0.4  | [optional] 
**DeconvergedNetConfig** | [**VsanDeconvergedNetConfig**](VsanDeconvergedNetConfig.md) | De-converged network configuration for vSAN.  | [optional] 
**VbossClusterConfig** | [**VsanVbossClusterConfig**](VsanVbossClusterConfig.md) | The cluster level configuration of vSAN vBoss service.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

