# Vcenter.ViJson.OpenApi.Model.ClearComplianceStatusRequestType
The parameters of *ProfileComplianceManager.ClearComplianceStatus*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If specified, clear the ComplianceResult related to the Profile.  Refers instances of *Profile*.  | [optional] 
**Entity** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | If specified, clear the ComplianceResult related to the entity. If profile and entity are not specified, all the ComplianceResults will be cleared.  Refers instances of *ManagedEntity*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

