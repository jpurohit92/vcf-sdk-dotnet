# Vcenter.Automation.OpenApi.Model.VcenterDeploymentDataMigrationInfo
The Vcenter.Deployment.DataMigrationInfo {schema contains the disk space requirements and time estimates for the different choices available to migrate the vCenter Server data.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Core** | [**VcenterDeploymentDataMigrationEstimate**](VcenterDeploymentDataMigrationEstimate.md) | Migrate only core data and configuration from vCenter Server. Events, tasks, and stats will not be migrated.  This property was added in __vSphere API 7.0.0.0__. | 
**CoreEventsTasks** | [**VcenterDeploymentDataMigrationEstimate**](VcenterDeploymentDataMigrationEstimate.md) | Migrate core, events, and tasks from vCenter Server. Stats will not be migrated.  This property was added in __vSphere API 7.0.0.0__. | 
**All** | [**VcenterDeploymentDataMigrationEstimate**](VcenterDeploymentDataMigrationEstimate.md) | Migrate all data from vCenter Server.  This property was added in __vSphere API 7.0.0.0__. | 
**CoreEventsTasksWithDeferred** | [**VcenterDeploymentDataMigrationEstimate**](VcenterDeploymentDataMigrationEstimate.md) | Migrate core, events, and tasks from vCenter Server. Events and tasks will be migrated after the upgrade. Stats will not be migrated.  This property was added in __vSphere API 7.0.0.0__.  This property will be available only if the source database is using an external database. | [optional] 
**AllWithDeferred** | [**VcenterDeploymentDataMigrationEstimate**](VcenterDeploymentDataMigrationEstimate.md) | Migrate all data from vCenter Server. Events, tasks, and stats will be migrated after the upgrade.  This property was added in __vSphere API 7.0.0.0__.  This property will be available only if the source database is using an external database. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

