# Vcenter.ViJson.OpenApi.Model.QueryComplianceStatusRequestType
The parameters of *ProfileComplianceManager.QueryComplianceStatus*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If specified, compliance result for the specified profiles will be returned. This acts like a filtering criteria for the ComplianceResults based on specified profiles.  Refers instances of *Profile*.  | [optional] 
**Entity** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If specified, compliance results for these entities will be returned. This acts like a filtering criteria for the ComplianceResults based on entities.  Refers instances of *ManagedEntity*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

