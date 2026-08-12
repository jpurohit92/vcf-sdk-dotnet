# Vcenter.ViJson.OpenApi.Model.ComplianceResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**ManagedObjectReference**](ManagedObjectReference.md) | Profile for which the ComplianceResult applies  Refers instance of *Profile*.  | [optional] 
**ComplianceStatus** | **string** | Indicates the compliance status of the entity.  See @link Status  | 
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | Entity on which the compliance check was carried out.  Entity can be a Cluster, Host and so on.  Refers instance of *ManagedEntity*.  | [optional] 
**CheckTime** | **DateTime** | Time at which compliance check was last run on the entity  | [optional] 
**Failure** | [**List&lt;ComplianceFailure&gt;**](ComplianceFailure.md) | If complianceStatus is non-compliant, failure will contain additional information about the compliance errors.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

