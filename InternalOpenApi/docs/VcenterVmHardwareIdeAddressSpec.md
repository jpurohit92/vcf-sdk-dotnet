# Vcenter.Automation.OpenApi.Model.VcenterVmHardwareIdeAddressSpec
The Vcenter.Vm.Hardware.IdeAddressSpec schema contains information for specifying the address of a virtual device that is attached to a virtual IDE adapter of a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Primary** | **bool** | Flag specifying whether the device should be attached to the primary or secondary IDE adapter of the virtual machine.  If missing or &#x60;null&#x60;, the server will choose a adapter with an available connection. If no IDE connections are available, the request will be rejected. | [optional] 
**Master** | **bool** | Flag specifying whether the device should be the master or slave device on the IDE adapter.  If missing or &#x60;null&#x60;, the server will choose an available connection type. If no IDE connections are available, the request will be rejected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

