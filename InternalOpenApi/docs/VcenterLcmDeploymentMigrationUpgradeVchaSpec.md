# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeVchaSpec
The Vcenter.Lcm.Deployment.MigrationUpgrade.VchaSpec schema specifies the VMware vCenter High Availability (VCHA) configuration required for upgrading vCenter with manually configured VCHA. It details the vCenter container locations for cloning Passive and Witness nodes post-upgrade, ensuring they are recreated in the same locations as before the upgrade.    Note: This configuration does not support standalone ESX instances. For such setups, users are required to manually recreate Passive and Witness nodes on the respective ESX instances and then re-enable VCHA on the upgraded system.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassiveNodeContainer** | [**VcenterLcmDeploymentCommonConnection**](VcenterLcmDeploymentCommonConnection.md) | Specifies connection to vCenter instance where passive node resides and will be recreated after successful upgrade.  This property was added in __vSphere API 9.0.0.0__. | 
**WitnessNodeContainer** | [**VcenterLcmDeploymentCommonConnection**](VcenterLcmDeploymentCommonConnection.md) | Specifies connection to vCenter instance where witness node resides and will be recreated after successful upgrade.  This property was added in __vSphere API 9.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

