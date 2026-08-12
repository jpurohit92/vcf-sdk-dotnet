# Vcenter.Automation.OpenApi.Model.ApplianceUpdateInfo
The Appliance.Update.Info schema describes the state of the appliance update.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**State** | **string** | State of the appliance update.  Possible values:   - &#x60;UP_TO_DATE&#x60;: The appliance is up to date.   - &#x60;UPDATES_PENDING&#x60;: A new update is available.   - &#x60;STAGE_IN_PROGRESS&#x60;: The appliance update is in progress of downloading an update.   - &#x60;INSTALL_IN_PROGRESS&#x60;: The appliance update is in progress of installing an update.   - &#x60;INSTALL_FAILED&#x60;: The appliance update failed and cannot recover.   - &#x60;ROLLBACK_IN_PROGRESS&#x60;: The appliance update failed and recovery is in progress.   For more information see: *Appliance.Update.State*.  This property was added in __vSphere API 6.7__. | 
**Task** | [**ApplianceTaskInfo**](ApplianceTaskInfo.md) | The running or completed update task.  This property was added in __vSphere API 6.7__. | [optional] 
**VarVersion** | **string** | Version of base appliance if state is UP_TO_DATE Version of update being staged or installed if state is INSTALL_IN_PROGRESS or STAGE_IN_PROGRESS Version of update staged if state is UPDATES_PENDING Version of update failed if state is INSTALL_FAILED or ROLLBACK_IN_PROGRESS  This property was added in __vSphere API 6.7__. | 
**LatestQueryTime** | **DateTime** | Timestamp of latest query to update repository.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; the update was never queried | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

