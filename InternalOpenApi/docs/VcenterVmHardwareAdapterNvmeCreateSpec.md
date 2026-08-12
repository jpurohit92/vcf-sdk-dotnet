# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareAdapterNvmeCreateSpec
The Vcenter.Vm.Hardware.Adapter.Nvme.CreateSpec schema provides a specification for the configuration of a newly-created virtual NVMe adapter.  This schema was added in __vSphere API 7.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Bus** | **long** | NVMe bus number.  This property was added in __vSphere API 7.0.0.1__.  If missing or &#x60;null&#x60;, the server will choose an available bus number; if none is available, the request will fail. | [optional] 
**PciSlotNumber** | **long** | Address of the NVMe adapter on the PCI bus.  This property was added in __vSphere API 7.0.0.1__.  If missing or &#x60;null&#x60;, the server will choose an available address when the virtual machine is powered on. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

