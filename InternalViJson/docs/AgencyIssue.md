# Vcenter.ViJson.OpenApi.Model.AgencyIssue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | A unique identifier per &lt;code&gt;Issue&lt;/code&gt; instance.  | 
**Description** | **string** | A localized message describing the issue.  | 
**Time** | **DateTime** | The point in time when this issue was generated.  Note that issues can be regenerated periodically, so this time does not necessarily reflect the first time the issue was detected.  | 
**Agency** | [**ManagedObjectReference**](ManagedObjectReference.md) | The agency to which this issue belongs.  Refers instance of *Agency*.  | 
**AgencyName** | **string** | The name of the agency.  | 
**SolutionId** | **string** | The ID of the solution to which this issue belongs.  | 
**SolutionName** | **string** | The name of the solution to which this issue belongs.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

