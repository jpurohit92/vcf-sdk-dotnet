# Vcenter.ViJson.OpenApi.Model.SolutionsSolutionComplianceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Solution** | **string** | Solution checked for compliance.  | 
**Compliant** | **bool** | &#x60;True&#x60; if the compute solution is compliant with the described desired state, &#x60;False&#x60; - otherwise.  | 
**NonComplianceReason** | **string** | Reason the solution is non-compliant *SolutionsNonComplianceReason_enum*.  | [optional] 
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | system Virtual Machine created for the solution.  Refers instance of *VirtualMachine*.  | [optional] 
**UpgradingVm** | [**ManagedObjectReference**](ManagedObjectReference.md) | system Virtual Machine created for upgrading the obsoleted system Virtual Machine.  Refers instance of *VirtualMachine*.  | [optional] 
**Hook** | [**SolutionsHookInfo**](SolutionsHookInfo.md) | Hook, ESX Agent Manager is awaiting to be processed for this solution.  | [optional] 
**Issues** | [**List&lt;Issue&gt;**](Issue.md) | Issues, ESX Agent Manager has encountered while attempting to achieve the solution&#39;s requested desired state.  | [optional] 
**SolutionConfig** | [**SolutionsSolutionConfig**](SolutionsSolutionConfig.md) | Last desired state for the solution, requested from ESX Agent Manager, for application.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

