# Vcenter.ViJson.OpenApi.Model.SolutionsHookInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | Virtual Machine, the hook was raised for.  Refers instance of *VirtualMachine*.  | 
**Solution** | **string** | Solution the Virtual Machine belongs to.  | 
**Config** | [**SolutionsHookConfig**](SolutionsHookConfig.md) | Configuration of the hook.  | 
**RaisedAt** | **DateTime** | Time the hook was raised.  | 
**DynamicUpdateProcessed** | **bool** | True if *Hooks#processDynamicUpdate* method invocation completed successfully for this hook.  Otherwise defaults to False.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

