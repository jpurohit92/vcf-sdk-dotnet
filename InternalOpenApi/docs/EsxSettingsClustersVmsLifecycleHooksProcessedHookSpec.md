# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsLifecycleHooksProcessedHookSpec
The Esx.Settings.Clusters.Vms.LifecycleHooks.ProcessedHookSpec schema contains properties that describe a specification for marking a hook as processed.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | **string** | Identifier of the VM whose hook needs to be marked as processed.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. | 
**LifecycleState** | **string** | Expected VM lifecycle state of the VM specified by the vm for which the hook is activated.  Possible values:   - &#x60;POST_PROVISIONING&#x60;: Post VM provisioning, reached once immediately after a VM is created.   - &#x60;POST_POWER_ON&#x60;: Post VM power-on, reached immediately after every VM power-on.   For more information see: *Esx.Settings.Clusters.Vms.LifecycleState*.  This property was added in __vSphere API 9.0.0.0__. | 
**ProcessedSuccessfully** | **bool** | Result of the client hook processing. True if processed successfully, false otherwise.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

