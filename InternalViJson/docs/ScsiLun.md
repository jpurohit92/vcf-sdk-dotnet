# Vcenter.ViJson.OpenApi.Model.ScsiLun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The name of the device on the host.  For example, /dev/cdrom or \\\\\\\\serverX\\\\device\\_name.  | 
**DeviceType** | **string** | Device type when available: floppy, mouse, cdrom, disk, scsi device, or adapter.  | 
**Key** | **string** | Linkable identifier  | [optional] 
**Uuid** | **string** | Universally unique identifier for the LUN used to identify ScsiLun across multiple servers.  This identifier can be used to identify analogous objects in other views such as *HostMultipathInfoLogicalUnit* and *HostScsiTopologyLun*.  See also *HostMultipathInfoLogicalUnit*, *HostScsiTopologyLun*.  | 
**Descriptor** | [**List&lt;ScsiLunDescriptor&gt;**](ScsiLunDescriptor.md) | List of descriptors that can be used to identify the LUN object.  The uuid will also appear as a descriptor.  The id field in the descriptor is a string that can be used to correlate the ScsiLun across multiple servers. A ScsiLun may have multiple descriptors. The choice and order of these descriptors may be different on different servers.  Not all descriptors are suitable for correlation. Some descriptors are only sufficient to identify the ScsiLun within a single host. Each descriptor contains a quality property that indicates whether or not the descriptor is suitable for correlation.  | [optional] 
**CanonicalName** | **string** | Canonical name of the SCSI logical unit.  Disk partition or extent identifiers refer to this name when referring to a disk. Use this property to correlate a partition or extent to a specific SCSI disk.  See also *HostScsiDiskPartition.diskName*.  | [optional] 
**DisplayName** | **string** | User configurable display name of the SCSI logical unit.  A default display name will be used if available. If the display name is not supported, it will be unset. The display name does not have to be unique but it is recommended that it be unique.  | [optional] 
**LunType** | **string** | The type of SCSI device.  Must be one of the values of *ScsiLunType_enum*.  | 
**Vendor** | **string** | The vendor of the SCSI device.  | [optional] 
**Model** | **string** | The model number of the SCSI device.  | [optional] 
**Revision** | **string** | The revision of the SCSI device.  | [optional] 
**ScsiLevel** | **int** | The SCSI level of the SCSI device.  | [optional] 
**SerialNumber** | **string** | The serial number of the SCSI device.  For a device that is SCSI-3 compliant, this property is derived from page 80h of the Vital Product Data (VPD), as defined by the SCSI-3 Primary Commands (SPC-3) spec. Not all SCSI-3 compliant devices provide this information. For devices that are not SCSI-3 compliant, this property is not defined.  | [optional] 
**DurableName** | [**ScsiLunDurableName**](ScsiLunDurableName.md) | The durable name of the SCSI device.  For a SCSI-3 compliant device this property is derived from the payloads of pages 80h and 83h of the Vital Product Data (VPD) as defined by the T10 and SMI standards. For devices that do not provide this information, this property is not defined.  | [optional] 
**AlternateName** | [**List&lt;ScsiLunDurableName&gt;**](ScsiLunDurableName.md) | Alternate durable names.  Records all available durable names derived from page 80h of the Vital Product Data (VPD) and the Identification Vital Product Data (VPD) page 83h as defined by the SCSI-3 Primary Commands. For devices that are not SCSI-3 compliant this property is not defined.  | [optional] 
**StandardInquiry** | **List&lt;int&gt;** | Standard Inquiry payload.  For a SCSI-3 compliant device this property is derived from the standard inquiry data. For devices that are not SCSI-3 compliant this property is not defined.  | [optional] 
**QueueDepth** | **int** | The queue depth of SCSI device.  | [optional] 
**OperationalState** | **List&lt;string&gt;** | The operational states of the LUN.  When more than one item is present in the array, the first state should be considered the primary state. For example, a LUN may be \&quot;ok\&quot; and \&quot;degraded\&quot; indicating I/O is still possible to the LUN, but it is operating in a degraded mode.  See also *ScsiLunState_enum*.  | 
**Capabilities** | [**ScsiLunCapabilities**](ScsiLunCapabilities.md) | Capabilities of SCSI device.  | [optional] 
**VStorageSupport** | **string** | vStorage hardware acceleration support status.  This property represents storage acceleration provided by the SCSI logical unit. See *ScsiLunVStorageSupportStatus_enum* for valid values.  If a storage device supports hardware acceleration, the ESX host can offload specific virtual machine management operations to the storage device. With hardware assistance, the host performs storage operations faster and consumes less CPU, memory, and storage fabric bandwidth.  For vSphere 4.0 or earlier hosts, this value will be unset.  | [optional] 
**ProtocolEndpoint** | **bool** | Indicates that this SCSI LUN is protocol endpoint.  This property will be populated if and only if host supports VirtualVolume based Datastore. Check the host capability *HostCapability.virtualVolumeDatastoreSupported*. See *HostProtocolEndpoint*.  | [optional] 
**PerenniallyReserved** | **bool** | Indicates the state of a perennially reserved flag for a LUN.  If set for Raw Device Mapped (RDM) LUNs, the host startup or LUN rescan take comparatively shorter duration than when it is unset.  | [optional] 
**ClusteredVmdkSupported** | **bool** | Indicates if LUN has the prerequisite properties to enable Clustered Vmdk feature once formatted into VMFS Datastore.  | [optional] 
**ApplicationProtocol** | **string** | Indicates the current device protocol.  Application protocol for a device which is set based on input from vmkctl storage control plane. Must be one of the values of *DeviceProtocol_enum*.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**DispersedNs** | **bool** | Indicates whether namespace is dispersed.  Set to true when the namespace of LUN is dispersed.  ***Since:*** vSphere API Release 8.0.1.0  | [optional] 
**DeviceReservation** | **string** | Indicates whether a device is under SCSI/NVMe reservation.  Device reservation for a SCSI/NVMe device set based on values received from vmkernel. The list of supported values is defined in *ScsiLunLunReservationStatus_enum*. If unset, the reservation status is unknown.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

