# Vcenter.ViJson.OpenApi.Model.IscsiMigrationDependency

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MigrationAllowed** | **bool** | Indicates whether migration can be safely performed If migrationAllowed is False, the disallowReason will contain the specific condition that makes the migration attempt unsafe.  | 
**DisallowReason** | [**IscsiStatus**](IscsiStatus.md) | Reasons for not allowing migration.  Unset if migrationAllowed is true.  | [optional] 
**Dependency** | [**List&lt;IscsiDependencyEntity&gt;**](IscsiDependencyEntity.md) | Details of all the resources affected by migration.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

