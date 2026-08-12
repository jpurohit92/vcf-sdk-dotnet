# Vcenter.Automation.OpenApi.Model.ApplianceHealthDatabaseInfo
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Appliance.Health.Database.Info schema contains information about the health of the the database.  This schema was added in __vSphere API 7.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Database health status  Possible values:   - &#x60;UNHEALTHY&#x60;: The database is corrupted and vCenter server functionality will be impacted.   - &#x60;DEGRADED&#x60;: The database has issues but the impact on vCenter Server is low.   - &#x60;HEALTHY&#x60;: The database is healthy.   For more information see: *Appliance.Health.Database.Info.Status*.  This property was added in __vSphere API 7.0.0.1__. | 
**Messages** | [**List&lt;ApplianceHealthDatabaseMessage&gt;**](ApplianceHealthDatabaseMessage.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Messages describing any issues with the database, along with their severity.  This property was added in __vSphere API 7.0.0.1__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

