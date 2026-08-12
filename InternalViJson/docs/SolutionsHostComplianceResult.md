# Vcenter.ViJson.OpenApi.Model.SolutionsHostComplianceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | The host being checked for compliance.  Refers instance of *HostSystem*.  | 
**Compliant** | **bool** | &#x60;True&#x60; if the compute host is compliant with the described desired state, &#x60;False&#x60; - otherwise.  | 
**Solutions** | [**List&lt;SolutionsSolutionComplianceResult&gt;**](SolutionsSolutionComplianceResult.md) | Detailed per-solution compliance result of the host.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

