# Vcenter.Automation.OpenApi.Model.VcenterNamespacesMobilityVirtualmachinesImportsCondition
The Vcenter.Namespaces.Mobility.Virtualmachines.Imports.Condition schema represents a condition of the Import.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of condition.    Possible values may include, but not limited to:     - SpecValid    - NetworkBackingReady    - VirtualMachineReadyForImport    - VirtualMachineCreated    - VirtualMachineReady    - Completed    - RollbackVirtualMachineLocationCompleted    - RollbackVirtualMachinePropertyCompleted    - RollbackCustomResourceCompleted    - RollbackCompleted    This property was added in __vSphere API 9.0.0.0__. | 
**Reason** | **string** | The reason for the condition&#39;s last transition.  This property was added in __vSphere API 9.0.0.0__. | 
**Status** | **string** | The status of the condition.  Possible values:   - &#x60;TRUE&#x60;: The condition is true.   - &#x60;FALSE&#x60;: The condition is false.   - &#x60;UNKNOWN&#x60;: The condition is unknown.   For more information see: *Vcenter.Namespaces.Mobility.Virtualmachines.Imports.ConditionStatus*.  This property was added in __vSphere API 9.0.0.0__. | 
**Message** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | A human-readable message indicating details about the last transition.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the message details are not required for taking actions. Some conditions are user actionable in order for the import operation to reach the desired state. | [optional] 
**LastTransitionTime** | **DateTime** | Last time the condition transitioned from one status to another. This should be when the underlying condition changed.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if there are no status transitions for the condition. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

