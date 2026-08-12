# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareAdapterNvmeInfo
The Vcenter.Vm.Hardware.Adapter.Nvme.Info schema contains information about a virtual NVMe adapter.  This schema was added in __vSphere API 7.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Device label.  This property was added in __vSphere API 7.0.0.1__. | 
**Bus** | **long** | NVMe bus number.  This property was added in __vSphere API 7.0.0.1__. | 
**PciSlotNumber** | **long** | Address of the NVMe adapter on the PCI bus.  This property was added in __vSphere API 7.0.0.1__.  May be missing or &#x60;null&#x60; if the virtual machine has never been powered on since the adapter was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

