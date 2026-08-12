# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareClustersUpgradeStatus
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.Software.Clusters.UpgradeStatus schema contains detailed information about the cluster when upgraded is in progress.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DesiredVersion** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Desired version the cluster will be upgraded to.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the cluster upgrade is not in progress. | [optional] 
**Messages** | [**List&lt;VcenterNamespaceManagementSoftwareClustersMessage&gt;**](VcenterNamespaceManagementSoftwareClustersMessage.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Current set of messages associated with the upgrade state.  This property was added in __vSphere API 7.0.0.0__. | 
**Progress** | [**VcenterNamespaceManagementSoftwareClustersUpgradeProgress**](VcenterNamespaceManagementSoftwareClustersUpgradeProgress.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Information about upgrade progress.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the cluster upgrade is not in progress. | [optional] 
**Components** | [**List&lt;VcenterNamespaceManagementClustersCondition&gt;**](VcenterNamespaceManagementClustersCondition.md) | This property is deprecated as of __vSphere API 9.1.0.0__.  Information about control plane components&#39; upgrade status.  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60;, the cluster upgrade is not in progress. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

