# Vcenter.ViJson.OpenApi.Model.VsanHclNicInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceName** | **string** | The device name used by ESX to refer to the device right now, e.g.  vmhba1, vmnic0  | 
**DisplayName** | **string** | The human friendly product model description by which the controller announces itself, e.g., \&quot;Intel Corporation PIIX4 ...\&quot;.  | [optional] 
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
**FwVersion** | **string** | Ignore this value.  | [optional] 
**DriversOnHcl** | [**List&lt;VsanHclDriverInfo&gt;**](VsanHclDriverInfo.md) | If the device shows up on the HCL, and is supported for the release of ESXi, this field will list the supported driver versions, as well as additional information for each driver, like associated firmware.  | [optional] 
**Vmknic** | **string** | The name of physical NIC  | [optional] 
**UseByVsan** | **bool** | True if this physical NIC is used by vSAN.  | [optional] 
**RdmaConfig** | [**VsanNicRdmaInfo**](VsanNicRdmaInfo.md) | The RDMA configuration for the RDMA capable physical NIC.  | [optional] 
**VsanHostCompatibility** | **List&lt;string&gt;** | A list of vSAN configuration types supported by the physical NIC.  See also *VsanConfigType_enum*.  | [optional] 
**NicLinkSpeedInMbps** | **int** | The physical NIC link speed in mbps.  See *PhysicalNicLinkInfo.speedMb*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

