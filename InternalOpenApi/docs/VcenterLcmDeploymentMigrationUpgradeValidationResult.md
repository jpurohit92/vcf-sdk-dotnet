# Vcenter.Automation.OpenApi.Model.VcenterLcmDeploymentMigrationUpgradeValidationResult
The Vcenter.Lcm.Deployment.MigrationUpgrade.ValidationResult schema contains validation information for a given upgrade  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Notifications** | [**VcenterLcmNotifications**](VcenterLcmNotifications.md) | Lists of the information messages, issues and warnings regarding the specified upgrade version. It contains summarized information from the individual prechecks.  This property was added in __vSphere API 9.0.0.0__.  notifications Only set when there are notifications raised from any of the individual prechecks | [optional] 
**Details** | [**List&lt;VcenterLcmDeploymentMigrationUpgradePrecheckResult&gt;**](VcenterLcmDeploymentMigrationUpgradePrecheckResult.md) | List of individual prechecks executed as part of the precheck request.  This property was added in __vSphere API 9.1.0.0__.  details Only set for versions that support fine-grain precheck reporting | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

