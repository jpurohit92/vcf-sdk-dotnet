# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradePostUpgradeConfigurationPolicy
The Vcenter.Lcm.Deployment.MigrationUpgrade.PostUpgradeConfigurationPolicy schema contains configuration information to be applied on successful upgrade.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RenameVmPolicy** | [**VcenterLcmDeploymentMigrationUpgradeRenameVmPolicy**](VcenterLcmDeploymentMigrationUpgradeRenameVmPolicy.md) | Provides options to preserve the original VM name as part of the upgrade, and to change the old vCenter VM name.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the VM name will be left as they are. | [optional] 
**DeleteVmPolicy** | [**VcenterLcmDeploymentMigrationUpgradeDeleteVmPolicy**](VcenterLcmDeploymentMigrationUpgradeDeleteVmPolicy.md) | Provides the ability to delete the source vCenter VM after upgrade.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; the source VM will not be deleted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

