# Vcenter.ViJson.OpenApi.Model.VsanHostConfigInfoStorageInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoClaimStorage** | **bool** | Deprecated as this configuration will be deprecated, autoclaim will be no longer supported.  Whether the VSAN service is configured to automatically claim local unused storage on this host.  When set, the VSAN service will automatically format and use local disks. Side effects from any disk consumption will be reflected in *VsanHostConfigInfoStorageInfo.diskMapping*. If this argument is specified as a host-level configuration input at the VC-level (see *ClusterConfigInfoEx.vsanHostConfig*), it will override that of any cluster-level default value.  See also *VsanHostConfigInfoStorageInfo.diskMapping*, *ClusterConfigInfoEx.vsanHostConfig*, *VsanClusterConfigInfo.defaultConfig*.  | [optional] 
**DiskMapping** | [**List&lt;VsanHostDiskMapping&gt;**](VsanHostDiskMapping.md) | Deprecated use *VsanHostConfigInfoStorageInfo.diskMapInfo* instead.  List of *VsanHostDiskMapping* entries in use by the VSAN service.  DiskMappings to be used by the VSAN service may be manually specified using *HostVsanSystem.InitializeDisks_Task*.  See also *HostVsanSystem.InitializeDisks_Task*.  | [optional] 
**DiskMapInfo** | [**List&lt;VsanHostDiskMapInfo&gt;**](VsanHostDiskMapInfo.md) | List of *VsanHostDiskMapping* entries with runtime information from the perspective of this host.  | [optional] 
**ChecksumEnabled** | **bool** | Deprecated this attribute was originally used for indicating whether hardware checksums is supported on the disks. But in vSphere 2016 hardware checksums are replaced with software implementation, supported by all disks. This makes current field redundant, and its value as an input/output is ignored.  Whether checksum is enabled on all the disks in this host.  If any disk is not checksum capable or 520 bps formatted, we will skip it.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

