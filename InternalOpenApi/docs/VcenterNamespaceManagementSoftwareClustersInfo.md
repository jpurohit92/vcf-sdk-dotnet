# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareClustersInfo
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.Software.Clusters.Info schema contains detailed information about the cluster upgrade status and related information.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentVersion** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Current version of the cluster.  This property was added in __vSphere API 7.0.0.0__. | 
**AvailableVersions** | **List&lt;string&gt;** | This property is deprecated as of __vSphere API 9.1.0.0__.  Set of available versions can be upgraded to.  This property was added in __vSphere API 7.0.0.0__. | 
**LastUpgradedDate** | **DateTime** | This property is deprecated as of __vSphere API 9.1.0.0__.  Date of last successful upgrade.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the cluster has not yet been upgraded. | [optional] 
**Messages** | [**List&lt;VcenterNamespaceManagementSoftwareClustersMessage&gt;**](VcenterNamespaceManagementSoftwareClustersMessage.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Current set of messages associated with the cluster version.  This property was added in __vSphere API 7.0.0.0__. | 
**State** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Current state of the upgrade.  Possible values:   - &#x60;PENDING&#x60;: Upgrade is in progress.   - &#x60;READY&#x60;: Cluster is ready when there is no upgrade or upgrade is completed.   - &#x60;ERROR&#x60;: Upgrade failed and need user intervention.   For more information see: *Vcenter.NamespaceManagement.Software.Clusters.State*.  This property was added in __vSphere API 7.0.0.0__. | 
**UpgradeStatus** | [**VcenterNamespaceManagementSoftwareClustersUpgradeStatus**](VcenterNamespaceManagementSoftwareClustersUpgradeStatus.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Information about upgrade in progress.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the cluster upgrade is not in progress. | [optional] 
**UpgradePrechecks** | [**List&lt;VcenterNamespaceManagementClustersCondition&gt;**](VcenterNamespaceManagementClustersCondition.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Detailed information about Supervisor upgrade pre-checks.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, the cluster pre-checks did not run or supervisor upgrade is not available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

