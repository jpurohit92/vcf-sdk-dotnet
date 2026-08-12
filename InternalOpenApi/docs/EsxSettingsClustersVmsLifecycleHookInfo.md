# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsLifecycleHookInfo
The Esx.Settings.Clusters.Vms.LifecycleHookInfo schema contains properties that describe a VM lifecycle hook that is activated for a given VM.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | **string** | Identifier of the VM for which the hook is activated.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;VirtualMachine&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;VirtualMachine&#x60;. | 
**LifecycleState** | **string** | VM lifecycle state of the VM specified by vm  Possible values:   - &#x60;POST_PROVISIONING&#x60;: Post VM provisioning, reached once immediately after a VM is created.   - &#x60;POST_POWER_ON&#x60;: Post VM power-on, reached immediately after every VM power-on.   For more information see: *Esx.Settings.Clusters.Vms.LifecycleState*.  This property was added in __vSphere API 9.0.0.0__. | 
**VarConfiguration** | [**EsxSettingsClustersVmsLifecycleHookConfig**](EsxSettingsClustersVmsLifecycleHookConfig.md) | Configuration of the hook.  This property was added in __vSphere API 9.0.0.0__. | 
**HookActivated** | **DateTime** | The vLCM system time when the hook is activated.  This property was added in __vSphere API 9.0.0.0__. | 
**DynamicUpdateProcessed** | **bool** | This property represents if the DynamicUpdateSpec given with *POST /esx/settings/clusters/{cluster}/vms/lifecycle-hooks?action&#x3D;process-dynamic-update* is applied successfully for the {#member lifecycleState} of the given {#member vm}.    Defaults to False.    See *POST /esx/settings/clusters/{cluster}/vms/lifecycle-hooks?action&#x3D;process-dynamic-update* about how to process the dynamic update for a given Esx.Settings.Clusters.Vms.LifecycleState.  This property was added in __vSphere API 9.1.0.0__.  This property is optional because it was added in a newer version than its parent node. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

