# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeSourceShutdownPolicy
The Vcenter.Lcm.Deployment.MigrationUpgrade.SourceShutdownPolicy enumerated type defines when the source vCenter to be shutdown during the upgrade, if it is to be shutdown.  Possible values:   - `NO_SHUTDOWN`: The source vCenter should not be shutdown by the upgrade process. However, the vCenter services will be disabled and the network interfaces will be brought down to ensure there are no conflicts during the upgrade   - `DURING_UPGRADE`: The source vCenter should be shutdown during the upgrade.   - `ON_SUCCESSFUL_UPGRADE`: The source vCenter should be shutdown after successful upgrade.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

