# Vcenter.Automation.OpenApi.Model.VcenterNamespacesMobilityVirtualmachinesImportsState
The Vcenter.Namespaces.Mobility.Virtualmachines.Imports.State schema represents the observed state of the Import.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Conditions** | [**List&lt;VcenterNamespacesMobilityVirtualmachinesImportsCondition&gt;**](VcenterNamespacesMobilityVirtualmachinesImportsCondition.md) | List of conditions describing the current state of the Import.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the Kubernetes resource associated with this operation is not yet created or ready to report conditions. | [optional] 
**StartTime** | **DateTime** | The time when the operation starts in the Supervisor. It is represented in RFC3339 form and is UTC.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the operation has not started yet. | [optional] 
**CompletionTime** | **DateTime** | The time when the operation finishes in the Supervisor. It is represented in RFC3339 form and is UTC.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; if the operation has not completed yet. | [optional] 
**VirtualMachineName** | **string** | The name of the virtual machine in the target namespace of the Supervisor.  This property was added in __vSphere API 9.0.0.0__.  This property will be missing or &#x60;null&#x60; until the VM is imported. The value corresponds to the name in vm-operator virtualmachine and does not match the display name in vCenter Server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

