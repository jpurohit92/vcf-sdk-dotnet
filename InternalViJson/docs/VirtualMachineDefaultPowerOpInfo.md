# Vcenter.ViJson.OpenApi.Model.VirtualMachineDefaultPowerOpInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PowerOffType** | **string** | Describes the default power off type for this virtual machine.  The possible values are specified by the PowerOpType. - hard - Perform power off by using the PowerOff method. - soft - Perform power off by using the ShutdownGuest method. - preset - The preset value is specified in the defaultPowerOffType   section.    This setting is advisory and clients can choose to ignore it.  | [optional] 
**SuspendType** | **string** | Describes the default suspend type for this virtual machine.  The possible values are specified by the PowerOpType. - hard - Perform suspend by using the Suspend method. - soft - Perform suspend by using the StandbyGuest method. - preset - The preset value is specified in the defaultSuspendType   section.    This setting is advisory and clients can choose to ignore it.  | [optional] 
**ResetType** | **string** | Describes the default reset type for this virtual machine.  The possible values are specified by the PowerOpType. - hard - Perform reset by using the Reset method. - soft - Perform reset by using the RebootGuest method. - preset - The preset value is specified in the defaultResetType   section.    This setting is advisory and clients can choose to ignore it.  | [optional] 
**DefaultPowerOffType** | **string** | Default operation for power off: soft or hard  | [optional] 
**DefaultSuspendType** | **string** | Default operation for suspend: soft or hard  | [optional] 
**DefaultResetType** | **string** | Default operation for reset: soft or hard  | [optional] 
**StandbyAction** | **string** | Behavior of virtual machine when it receives the S1 ACPI call.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

