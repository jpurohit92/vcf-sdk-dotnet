# Vcenter.ViJson.OpenApi.Model.AutoStartPowerInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual machine to power on or power off.  Refers instance of *VirtualMachine*.  | 
**StartOrder** | **int** | The autostart priority of this virtual machine.  Virtual machines with a lower number are powered on first. On host shutdown, the virtual machines are shut down in reverse order, meaning those with a higher number are powered off first.  Positive values indicate a start order and -1 indicates the machine can be powered on at any time. Machines with a -1 value are typically powered on and off after all virtual machines with positive startOrder values. Failure to meet the following requirements results in an InvalidArgument exception: - startOrder must be set to -1 if startAction is set to none - startOrder must be -1 or positive integers. Values such as 0 or   \\-2 are not valid. - startOrder is relative to other virtual machines in the autostart   sequence. Hence specifying a startOrder of 4 when there are only 3   virtual machines in the Autostart sequence is not valid.    If a newly established or changed startOrder value for a virtual machine matches an existing startOrder value, the newly applied value takes precedence, and the existing value is incremented by one. The incremented startOrder value is checked for collisions, and the same rule is applied if one is found. This simple system ensures no two virtual machines ever have the same order number.  For example, consider the case where there are three virtual machines with different startOrder values. Virtual machine A has not yet established a startOrder, virtual machine B has a startOrder value of 1 and Virtual Machine C has a startOrder value of 2. If virtual machine A&#39;s startOrder is set to 1, then virtual machine B&#39;s startOrder is incremented to 2. This creates a conflict with virtual machine C&#39;s startOrder value, which is also incremented, this time to 3.  | 
**StartDelay** | **int** | Delay in seconds before continuing with the next virtual machine in the order of machines to be started.  If the delay is specified as -1, then the system default is used.  | 
**WaitForHeartbeat** | **AutoStartWaitHeartbeatSettingEnum** |  | 
**StartAction** | **string** | How to start the virtual machine.  Valid settings are none or powerOn. If set to none, then the virtual machine does not participate in auto-start.  | 
**StopDelay** | **int** | Delay in seconds before continuing with the next virtual machine in the order sequence.  If the delay is -1, then the system default is used.  | 
**StopAction** | **string** | Defines the stop action for the virtual machine.  Can be set to none, systemDefault, powerOff, or suspend. If set to none, then the virtual machine does not participate in auto-stop.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

