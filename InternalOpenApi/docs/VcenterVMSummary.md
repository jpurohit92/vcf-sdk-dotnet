# Vcenter.Automation.OpenApi.Model.VcenterVMSummary
The Vcenter.VM.Summary schema contains commonly used information about a virtual machine.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | **string** | Identifier of the virtual machine.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. | 
**Name** | **string** | Name of the Virtual machine. | 
**PowerState** | **string** | Power state of the virtual machine.  Possible values:   - &#x60;POWERED_OFF&#x60;: The virtual machine is powered off.   - &#x60;POWERED_ON&#x60;: The virtual machine is powered on.   - &#x60;SUSPENDED&#x60;: The virtual machine is suspended.   For more information see: *Vcenter.Vm.Power.State*. | 
**CpuCount** | **long** | Number of CPU cores.  This property will be missing or &#x60;null&#x60; if the virtual machine configuration is not available. For example, the configuration information would be unavailable if the server is unable to access the virtual machine files on disk, and is often also unavailable during the initial phases of virtual machine creation. | [optional] 
**MemorySizeMib** | **long** | Memory size in mebibytes.  This property will be missing or &#x60;null&#x60; if the virtual machine configuration is not available. For example, the configuration information would be unavailable if the server is unable to access the virtual machine files on disk, and is often also unavailable during the initial phases of virtual machine creation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

