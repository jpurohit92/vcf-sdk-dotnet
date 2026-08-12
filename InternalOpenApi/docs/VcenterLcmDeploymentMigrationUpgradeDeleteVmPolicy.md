# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeDeleteVmPolicy
The Vcenter.Lcm.Deployment.MigrationUpgrade.DeleteVmPolicy schema is used to instruct the upgrade process to delete the source vCenter VM on a successful upgrade.    To use this provide the container managing the source vCenter by setting *Vcenter.Lcm.Deployment.Common.ApplianceDeploymentConfig.source_container* in *Vcenter.Lcm.Deployment.MigrationUpgrade.InitSpec.deployment* or ensure the source vCenter is self-managed. The upgrade process will be prevented to start without such access, if this option is used.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceVc** | **bool** | Provides the ability to delete the source vCenter VM on a successful upgrade. This is executed immediately before successful upgrade is declared and the source machine will not be usable as a backup afterwards. Any failures during the deletion will be reported as warnings and will not break the upgrade.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

