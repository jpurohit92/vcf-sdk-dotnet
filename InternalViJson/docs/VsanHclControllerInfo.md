# Vcenter.ViJson.OpenApi.Model.VsanHclControllerInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The device name used by ESX to refer to the device right now, e.g.  vmhba1.  | 
**DeviceDisplayName** | **string** | The human friendly product model description by which the controller announces itself, e.g., \&quot;Intel Corporation PIIX4 ...\&quot;.  | [optional] 
**DriverName** | **string** | The name of the driver, e.g.  mpt2sas.  | [optional] 
**DriverVersion** | **string** | The version of the driver as reported by the driver kernel module, e.g.  &#39;4.23.01.00-9vmw&#39;.  | [optional] 
**VendorId** | **long** | The vendorId of the PCI device, e.g.  4096.  | [optional] 
**DeviceId** | **long** | The deviceId of the PCI device, e.g.  48.  | [optional] 
**SubVendorId** | **long** | The subVendorId of the PCI device, e.g.  6518.  | [optional] 
**SubDeviceId** | **long** | The subDeviceId of the PCI device, e.g.  5549.  | [optional] 
**ExtraInfo** | [**List&lt;KeyValue&gt;**](KeyValue.md) | Any additional information not explicitly modeled in API.  Can be used for vendor specific information about features of a controller.  | [optional] 
**DeviceOnHcl** | **bool** | If the device shows up on the HCL at all.  | [optional] 
**ReleaseSupported** | **bool** | If the device is on the HCL and the release of ESXi in use is supported.  | [optional] 
**ReleasesOnHcl** | **List&lt;string&gt;** | If the device is on the HCL, this holds the names of the supported releases.  | [optional] 
**DriverVersionsOnHcl** | **List&lt;string&gt;** | If the device shows up on the HCL, and is supported for the release of ESXi, this field will list the supported driver versions.  | [optional] 
**DriverVersionSupported** | **bool** | If the device shows up on the HCL, and is supported for the release of ESXi, and the driver version is detected to be supported  | [optional] 
**FwVersionSupported** | **bool** | Ignore this value.  | [optional] 
**FwVersionOnHcl** | **List&lt;string&gt;** | Ignore this value.  | [optional] 
**CacheConfigSupported** | **bool** | Ignore this value.  | [optional] 
**CacheConfigOnHcl** | **List&lt;string&gt;** | Ignore this value.  | [optional] 
**RaidConfigSupported** | **bool** | Ignore this value.  | [optional] 
**RaidConfigOnHcl** | **List&lt;string&gt;** | Ignore this value.  | [optional] 
**FwVersion** | **string** | Ignore this value.  | [optional] 
**RaidConfig** | **string** | This field is not used.  | [optional] 
**CacheConfig** | **string** | This field is not used.  | [optional] 
**CimProviderInfo** | [**VsanHostCimProviderInfo**](VsanHostCimProviderInfo.md) | This field is not used.  | [optional] 
**UsedByVsan** | **bool** | Used by vSAN.  If not set, \&quot;True\&quot; should be assumed.  | [optional] 
**Disks** | [**List&lt;VsanHclDiskInfo&gt;**](VsanHclDiskInfo.md) | Additional information about disks behind this controller, if available.  | [optional] 
**Issues** | [**List&lt;MethodFault&gt;**](MethodFault.md) | Any issues detected with the configuration of the the controller.  | [optional] 
**RemediableIssues** | **List&lt;string&gt;** | Keys of issues which can be remediated.  | [optional] 
**DriversOnHcl** | [**List&lt;VsanHclDriverInfo&gt;**](VsanHclDriverInfo.md) | If the device shows up on the HCL, and is supported for the release of ESXi, this field will list the supported driver versions, as well as additional information for each driver, like associated firmware.  | [optional] 
**FwAuxVersion** | **string** | Auxiliary firmware version.  Some controllers use an additional firmware version, e.g. a \&quot;bundle version\&quot; or \&quot;build version\&quot;. If present, its populated here.  | [optional] 
**QueueDepth** | **long** | The maximum supported queue depth for the controller.  | [optional] 
**QueueDepthOnHcl** | **long** | If the device shows up on the HCL, and is supported for the release of ESXi, this field will show the supported queue depth for the controller.  | [optional] 
**QueueDepthSupported** | **bool** | If the device shows up on the HCL, and is supported for the release of ESX, this field checks if the controller&#39;s queue depth is supported.  | [optional] 
**DiskMode** | **string** | The disk mode (all flash or hybrid) for the disks on the controller.  | [optional] 
**DiskModeOnHcl** | **List&lt;string&gt;** | If the device shows up on the HCL, and is supported for the release of ESXi, this field will show the supported disk mode on HCL.  | [optional] 
**DiskModeSupported** | **bool** | If the device shows up on the HCL, and is supported for the release of ESXi, this field checks if the disk mode of the controller is supported.  | [optional] 
**ToolName** | **string** | The name of the vendor tool.  E.g., perccli.  | [optional] 
**ToolVersion** | **string** | The version of the vendor tool.  | [optional] 
**ProductId** | **string** | The product ID of a controller.  Only applicable for devices like NVMe.  | [optional] 
**DiskCapacity** | **long** | The capacity of a disk under the controller.  The Unit is byte. Only applicable for devices like NVMe.  | [optional] 
**VcgEntryInfo** | [**List&lt;VsanVcgDeviceInfo&gt;**](VsanVcgDeviceInfo.md) | A list of the matching models in vSAN VCG, the length of the list will be larger than 1 if this controller&#39;s PCI ID is used by other devices like NVMe on the vSAN VCG.  Otherwise, the length will be 1, which means there is a unique mapping from this controller to a vSAN VCG entry.  | [optional] 
**ControllerType** | **string** | Refer to *VsanControllerType_enum*  See also *VsanControllerType_enum*.  | [optional] 
**UserSelectedVcgId** | **int** | The vSAN VCG ID selected by the user.  This field will be empty if user has never made a selection, or this controller has a unique mapping to its vSAN VCG entry originally.  | [optional] 
**VsanCompatibility** | **List&lt;string&gt;** | A list of vSAN configurations supported by this controller.  See also *VsanConfigType_enum*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

