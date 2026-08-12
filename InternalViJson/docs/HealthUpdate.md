# Vcenter.ViJson.OpenApi.Model.HealthUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**ManagedObjectReference**](ManagedObjectReference.md) | The entity on which the health update occurred.  Only host is supported.  Refers instance of *ManagedEntity*.  | 
**HealthUpdateInfoId** | **string** | The ID of the corresponding HealthUpdateInfo.  | 
**Id** | **string** | The ID of this particular HealthUpdate instance, for cross-reference with HealthUpdateProvider logs.  | 
**Status** | **ManagedEntityStatusEnum** | The current health status.  Values are of type *Status*.  | 
**Remediation** | **string** | A description of the physical remediation required to resolve this health update.  For example, \&quot;Replace Fan #3\&quot;.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

