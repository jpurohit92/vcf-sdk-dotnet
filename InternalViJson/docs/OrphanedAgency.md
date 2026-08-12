# Vcenter.ViJson.OpenApi.Model.OrphanedAgency
Deprecated eAM no longer raises this issue. If agecny is getting orphaned EAM simply destroys it.  The solution that created the agency is no longer registered with the vCenter server.  This is an active remediable issue. To remediate, vSphere ESX Agent Manager undeploys and removes the agency.  This structure may be used only with operations rendered under `/eam`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Agency** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agency to which this issue belongs.  Refers instance of *Agency*.  | 
**AgencyName** | **string** | The name of the agency.  | 
**SolutionId** | **string** | The ID of the solution to which this issue belongs.  | 
**SolutionName** | **string** | The name of the solution to which this issue belongs.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

