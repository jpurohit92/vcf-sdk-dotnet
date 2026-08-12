# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareScsiAddressSpec
The Vcenter.Vm.Hardware.ScsiAddressSpec schema contains information for specifying the address of a virtual device that is attached to a virtual SCSI adapter of a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bus** | **long** | Bus number of the adapter to which the device should be attached. | 
**Unit** | **long** | Unit number of the device.  If missing or &#x60;null&#x60;, the server will choose an available unit number on the specified adapter. If there are no available connections on the adapter, the request will be rejected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

