# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeRenameVmPolicy
The Vcenter.Lcm.Deployment.MigrationUpgrade.RenameVmPolicy schema instructs the upgrade to preserve the original vCenter VM name on successful upgrade and allows changing the old vCenter VM name. The upgrade needs access to the container managing the old vCenter VM - either provide *Vcenter.Lcm.Deployment.Common.ApplianceDeploymentConfig.source_container* or ensure that the environment is self managed. Otherwise, the upgrade process validation will fail if this option is used.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreserveOriginalVmName** | **bool** | Instructs the upgrade to preserve the old vCenter VM name on the new vCenter. In the process the old vCenter VM name will also be changed. Use oldVcenterName if you want to set it to a non-default name.  This property was added in __vSphere API 9.0.0.0__. | 
**OldVcenterName** | **string** | Allows changing the old vCenter VM name post upgrade. When the old VC VM name is preserved on new VC, the original VM itself needs to be renamed to avoid name collision with the new version.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; and preserveOriginalVmName is set to False the name of the original vCenter will be left as is. If missing or &#x60;null&#x60; and preserveOriginalVmName is set to True the name will be changed to the old name appended with -old-&lt;version&gt;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

