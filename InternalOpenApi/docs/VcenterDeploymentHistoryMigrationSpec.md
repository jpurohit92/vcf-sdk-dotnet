# Vcenter.Automation.OpenApi.Model.VcenterDeploymentHistoryMigrationSpec
The Vcenter.Deployment.HistoryMigrationSpec enumerated type defines how vCenter history data will be migrated. vCenter History data includes     - Statistics    - Events    - Tasks    This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataSet** | **string** | Defines what part of vCenter historical data will be migrated along with core data.  Possible values:   - &#x60;EVENTS_TASKS&#x60;: Only event data and task data will be migrated along with the core data.   - &#x60;ALL&#x60;: All history data will be migrated along with the core data.   For more information see: *Vcenter.Deployment.HistoryMigrationOption*.  This property was added in __vSphere API 6.7__. | 
**DeferImport** | **bool** | Defines how vCenter history will be migrated. If set to true, vCenter history will be migrated separately after successful upgrade(supported scenarios are upgrade from 6.0 or 6.5 to 6.7) or migration, otherwise it will be migrated along with core data during the upgrade or migration process. vCSA upgrade with deferred import is no longer supported for target version 7.0 and later.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, vCenter historical data won&#39;t be deferred and will be migrated along with core data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

