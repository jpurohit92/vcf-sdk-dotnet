# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareNvmeAddressSpec
The Vcenter.Vm.Hardware.NvmeAddressSpec schema contains information for specifying the address of a virtual device that is attached to a virtual NVMe adapter of a virtual machine.  This schema was added in __vSphere API 7.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bus** | **long** | Bus number of the adapter to which the device should be attached.  This property was added in __vSphere API 7.0.0.1__. | 
**Unit** | **long** | Unit number of the device.  This property was added in __vSphere API 7.0.0.1__.  If missing or &#x60;null&#x60;, the server will choose an available unit number on the specified adapter. If there are no available connections on the adapter, the request will be rejected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

