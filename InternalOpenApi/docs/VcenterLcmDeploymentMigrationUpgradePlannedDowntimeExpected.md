# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradePlannedDowntimeExpected
The Vcenter.Lcm.Deployment.MigrationUpgrade.PlannedDowntime.Expected enumerated type defines the vCenter RDU planned downtime.  Possible values:   - `YES`: Downtime is scheduled and expected to start in the given timeframe. Downtime means new operations would not be accepted and ongoing operations would be interrupted.   - `NO`: No scheduled downtime and no planned downtime expected in the given timeframe.   - `UNKNOWN`: Downtime is not scheduled, but upgrade is in progress. Downtime is expected after the *Vcenter.Lcm.Deployment.MigrationUpgrade.Status.State.PREPARED* state, but exact time can not be estimated. It could happen within minutes, hours, or possibly days. A time critical operation could proceed with execution, but there is no guarantee that downtime will not interrupt it. Operations that should not be interrupted, should better wait unil they receive *Vcenter.Lcm.Deployment.MigrationUpgrade.PlannedDowntime.Expected.NO*, meaning it is safe to start workload.   This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

