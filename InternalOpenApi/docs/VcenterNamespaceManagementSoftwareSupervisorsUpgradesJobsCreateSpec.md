# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsUpgradesJobsCreateSpec
The Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.Jobs.CreateSpec schema contains the specification required to upgrade a Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DesiredVersion** | **string** | The target version to which the selected Supervisor will be upgraded.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. | 
**IgnorePrecheckWarnings** | **bool** | If true, the upgrade workflow will ignore any pre-check warnings and proceed with the upgrade.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the upgrade workflow will not ignore pre-check warnings and fail the upgrade. It is equivalent to setting the value to false. The workflow adopts a conservative approach of failing the upgrade if missing or &#x60;null&#x60; to solely let the user decide whether to force the upgrade despite the warnings. For example, if a precheck returns a warning because a TKC is not compatible with the target version, and the you still wants to continue with the upgrade, this flag should be set to true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

