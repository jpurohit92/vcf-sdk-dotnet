# Vcenter.ViJson.OpenApi.Model.IntegrityAgencyVUMIssue
Deprecated as of vSphere 9.0. Please refer to vLCM Image APIs.  Base class for all issues which occurred during EAM communication with vSphere Update Manager (VUM).  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agency** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agency to which this issue belongs.  Refers instance of *Agency*.  | 
**AgencyName** | **string** | The name of the agency.  | 
**SolutionId** | **string** | The ID of the solution to which this issue belongs.  | 
**SolutionName** | **string** | The name of the solution to which this issue belongs.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

