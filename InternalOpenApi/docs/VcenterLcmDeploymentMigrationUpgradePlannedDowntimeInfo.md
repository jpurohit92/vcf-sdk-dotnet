# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradePlannedDowntimeInfo
The Vcenter.Lcm.Deployment.MigrationUpgrade.PlannedDowntime.Info schema contains information about planned downtime expectations for the RDU upgrade.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expected** | **string** | The planned downtime expectations.  Possible values:   - &#x60;YES&#x60;: Downtime is scheduled and expected to start in the given timeframe. Downtime means new operations would not be accepted and ongoing operations would be interrupted.   - &#x60;NO&#x60;: No scheduled downtime and no planned downtime expected in the given timeframe.   - &#x60;UNKNOWN&#x60;: Downtime is not scheduled, but upgrade is in progress. Downtime is expected after the *Vcenter.Lcm.Deployment.MigrationUpgrade.Status.State.PREPARED* state, but exact time can not be estimated. It could happen within minutes, hours, or possibly days. A time critical operation could proceed with execution, but there is no guarantee that downtime will not interrupt it. Operations that should not be interrupted, should better wait unil they receive *Vcenter.Lcm.Deployment.MigrationUpgrade.PlannedDowntime.Expected.NO*, meaning it is safe to start workload.   For more information see: *Vcenter.Lcm.Deployment.MigrationUpgrade.PlannedDowntime.Expected*.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

