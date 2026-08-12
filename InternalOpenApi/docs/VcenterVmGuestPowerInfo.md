# Vcenter.Automation.OpenApi.Model.VcenterVmGuestPowerInfo
Information about the guest operating system power state.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | The power state of the guest operating system.  Possible values:   - &#x60;RUNNING&#x60;: The guest OS is running.   - &#x60;SHUTTING_DOWN&#x60;: The guest OS is shutting down   - &#x60;RESETTING&#x60;: The guest OS is resetting   - &#x60;STANDBY&#x60;: The guest OS is in standby.   - &#x60;NOT_RUNNING&#x60;: The guest OS is not running.   - &#x60;UNAVAILABLE&#x60;: The guest OS power state is unknown.   For more information see: *Vcenter.Vm.Guest.Power.State*.  This property was added in __vSphere API 6.7__. | 
**OperationsReady** | **bool** | Flag indicating if the virtual machine is ready to process soft power operations.  This property was added in __vSphere API 6.7__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

