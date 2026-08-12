# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareDiskInfo
The Vcenter.Vm.Hardware.Disk.Info schema contains information about a virtual disk.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Device label. | 
**Type** | **string** | Type of host bus adapter to which the device is attached.  Possible values:   - &#x60;IDE&#x60;: Disk is attached to an IDE adapter.   - &#x60;SCSI&#x60;: Disk is attached to a SCSI adapter.   - &#x60;SATA&#x60;: Disk is attached to a SATA adapter.   - &#x60;NVME&#x60;: Disk is attached to a NVMe adapter.  This constant was added in __vSphere API 7.0.0.1__.   For more information see: *Vcenter.Vm.Hardware.Disk.HostBusAdapterType*. | 
**Ide** | [**VcenterVmHardwareIdeAddressInfo**](VcenterVmHardwareIdeAddressInfo.md) | Address of device attached to a virtual IDE adapter.  Workaround for PR1459646 | [optional] 
**Scsi** | [**VcenterVmHardwareScsiAddressInfo**](VcenterVmHardwareScsiAddressInfo.md) | Address of device attached to a virtual SCSI adapter.  Workaround for PR1459646 | [optional] 
**Sata** | [**VcenterVmHardwareSataAddressInfo**](VcenterVmHardwareSataAddressInfo.md) | Address of device attached to a virtual SATA adapter.  Workaround for PR1459646 | [optional] 
**Nvme** | [**VcenterVmHardwareNvmeAddressInfo**](VcenterVmHardwareNvmeAddressInfo.md) | Address of device attached to a virtual NVMe adapter.  This property was added in __vSphere API 7.0.0.1__.  This property is optional and it is only relevant when the value of type is *Vcenter.Vm.Hardware.Disk.HostBusAdapterType.NVME*. | [optional] 
**Backing** | [**VcenterVmHardwareDiskBackingInfo**](VcenterVmHardwareDiskBackingInfo.md) | Physical resource backing for the virtual disk. | 
**Capacity** | **long** | Capacity of the virtual disk in bytes.  If missing or &#x60;null&#x60;, virtual disk is inaccessible or disk capacity is 0. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

