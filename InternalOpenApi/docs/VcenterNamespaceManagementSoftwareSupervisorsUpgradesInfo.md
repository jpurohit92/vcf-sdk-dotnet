# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsUpgradesInfo
The Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.Info schema contains detailed information about the Supervisor upgrade status and related information.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentVersion** | **string** | Current version of the Supervisor.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. | 
**AvailableVersions** | **List&lt;string&gt;** | Set of versions that the Supervisor can be upgraded to.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;SupervisorVersion&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;SupervisorVersion&#x60;. | 
**LastUpgradedDate** | **DateTime** | Date of the last successful upgrade.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the Supervisor has not yet been upgraded. | [optional] 
**Messages** | [**List&lt;VcenterNamespaceManagementSoftwareSupervisorsUpgradesMessage&gt;**](VcenterNamespaceManagementSoftwareSupervisorsUpgradesMessage.md) | Messages related to the upgrade process for the Supervisor.  This property was added in __vSphere API 9.1.0.0__. | 
**State** | **string** | Current state of the upgrade.  Possible values:   - &#x60;INPROGRESS&#x60;: Upgrade is in progress.   - &#x60;READY&#x60;: The Supervisor is ready for an upgrade. This state indicates that either:       - No upgrade has been initiated yet, or      - The most recent upgrade has completed successfully.   This is the default state when the Supervisor is idle or post-upgrade.   - &#x60;ERROR&#x60;: Upgrade has failed and needs user intervention.   For more information see: *Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.State*.  This property was added in __vSphere API 9.1.0.0__. | 
**UpgradeStatus** | [**VcenterNamespaceManagementSoftwareSupervisorsUpgradesStatus**](VcenterNamespaceManagementSoftwareSupervisorsUpgradesStatus.md) | Information about the upgrade in progress.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the Supervisor upgrade is not in progress. | [optional] 
**UpgradePrechecks** | [**List&lt;VcenterNamespaceManagementClustersCondition&gt;**](VcenterNamespaceManagementClustersCondition.md) | Detailed information about Supervisor upgrade pre-checks.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the Supervisor pre-checks did not run or Supervisor upgrade is not available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

