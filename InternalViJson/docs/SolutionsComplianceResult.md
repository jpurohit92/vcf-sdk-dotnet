# Vcenter.ViJson.OpenApi.Model.SolutionsComplianceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compliant** | **bool** | &#x60;True&#x60; if the compute resource is compliant with the described desired state, &#x60;False&#x60; - otherwise.  | 
**Hosts** | [**List&lt;SolutionsHostComplianceResult&gt;**](SolutionsHostComplianceResult.md) | Detailed per-host compliance result of the compute resource for solutions with *SolutionsHostBoundSolutionConfig*.  | [optional] 
**ClusterSolutionsCompliance** | [**List&lt;SolutionsClusterSolutionComplianceResult&gt;**](SolutionsClusterSolutionComplianceResult.md) | Detailed per-solution unit compliance result of the compute resource for solutions with *SolutionsClusterBoundSolutionConfig*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

