# Vcenter.ViJson.OpenApi.Model.HostStorageDeviceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HostBusAdapter** | [**List&lt;HostHostBusAdapter&gt;**](HostHostBusAdapter.md) | The list of host bus adapters available on the host.  | [optional] 
**ScsiLun** | [**List&lt;ScsiLun&gt;**](ScsiLun.md) | The list of SCSI logical units available on the host.  | [optional] 
**ScsiTopology** | [**HostScsiTopology**](HostScsiTopology.md) | Storage topology view of SCSI storage devices.  This data object exists only if storage topology information is available. See the *ScsiTopology* data object type for more information.  | [optional] 
**NvmeTopology** | [**HostNvmeTopology**](HostNvmeTopology.md) | Topology view of NVME storage devices.  This data object exists only if storage topology information is available. See the *HostNvmeTopology* data object type for more information.  | [optional] 
**MultipathInfo** | [**HostMultipathInfo**](HostMultipathInfo.md) | The multipath configuration that controls multipath policy for ScsiLuns.  This data object exists only if path information is available and is configurable.  | [optional] 
**PlugStoreTopology** | [**HostPlugStoreTopology**](HostPlugStoreTopology.md) | The plug-store topology on the host system.  This data object exists only if the plug-store system is available and configurable.  | [optional] 
**SoftwareInternetScsiEnabled** | **bool** | Indicates if the software iSCSI initiator is enabled on this system  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

