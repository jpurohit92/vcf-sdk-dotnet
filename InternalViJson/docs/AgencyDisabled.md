# Vcenter.ViJson.OpenApi.Model.AgencyDisabled
Agency is disabled - one or more ClusterComputeResources from it's scope are disabled.  This is not a remediable issue. To remediate, re-enable the cluster.  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 7.6 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agency** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agency to which this issue belongs.  Refers instance of *Agency*.  | 
**AgencyName** | **string** | The name of the agency.  | 
**SolutionId** | **string** | The ID of the solution to which this issue belongs.  | 
**SolutionName** | **string** | The name of the solution to which this issue belongs.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

