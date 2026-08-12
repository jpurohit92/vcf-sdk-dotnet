# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareDiskCreateSpec
The Vcenter.Vm.Hardware.Disk.CreateSpec schema provides a specification for the configuration of a newly-created virtual disk.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of host bus adapter to which the device should be attached.  Possible values:   - &#x60;IDE&#x60;: Disk is attached to an IDE adapter.   - &#x60;SCSI&#x60;: Disk is attached to a SCSI adapter.   - &#x60;SATA&#x60;: Disk is attached to a SATA adapter.   - &#x60;NVME&#x60;: Disk is attached to a NVMe adapter.  This constant was added in __vSphere API 7.0.0.1__.   For more information see: *Vcenter.Vm.Hardware.Disk.HostBusAdapterType*.  If missing or &#x60;null&#x60;, guest-specific default values will be used | [optional] 
**Ide** | [**VcenterVmHardwareIdeAddressSpec**](VcenterVmHardwareIdeAddressSpec.md) | Address for attaching the device to a virtual IDE adapter.  If missing or &#x60;null&#x60;, the server will choose an available address; if none is available, the request will fail. | [optional] 
**Scsi** | [**VcenterVmHardwareScsiAddressSpec**](VcenterVmHardwareScsiAddressSpec.md) | Address for attaching the device to a virtual SCSI adapter.  If missing or &#x60;null&#x60;, the server will choose an available address; if none is available, the request will fail. | [optional] 
**Sata** | [**VcenterVmHardwareSataAddressSpec**](VcenterVmHardwareSataAddressSpec.md) | Address for attaching the device to a virtual SATA adapter.  If missing or &#x60;null&#x60;, the server will choose an available address; if none is available, the request will fail. | [optional] 
**Nvme** | [**VcenterVmHardwareNvmeAddressSpec**](VcenterVmHardwareNvmeAddressSpec.md) | Address for attaching the device to a virtual NVMe adapter.  This property was added in __vSphere API 7.0.0.1__.  If missing or &#x60;null&#x60;, the server will choose an available address; if none is available, the request will fail. | [optional] 
**Backing** | [**VcenterVmHardwareDiskBackingSpec**](VcenterVmHardwareDiskBackingSpec.md) | Existing physical resource backing for the virtual disk. Exactly one of backing or new_vmdk must be specified.  If missing or &#x60;null&#x60;, the virtual disk will not be connected to an existing backing. | [optional] 
**NewVmdk** | [**VcenterVmHardwareDiskVmdkCreateSpec**](VcenterVmHardwareDiskVmdkCreateSpec.md) | Specification for creating a new VMDK backing for the virtual disk. Exactly one of backing or new_vmdk must be specified.  If missing or &#x60;null&#x60;, a new VMDK backing will not be created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

