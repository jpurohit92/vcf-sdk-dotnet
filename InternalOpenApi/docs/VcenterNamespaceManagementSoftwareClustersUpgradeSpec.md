# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareClustersUpgradeSpec
This schema is deprecated as of __vSphere API 9.1.0.0__.  The Vcenter.NamespaceManagement.Software.Clusters.UpgradeSpec schema contains the specification required to upgrade a cluster.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DesiredVersion** | **string** | This property is deprecated as of __vSphere API 9.1.0.0__.  Version number the cluster is going to be upgraded to.  This property was added in __vSphere API 7.0.0.0__. | 
**IgnorePrecheckWarnings** | **bool** | This property is deprecated as of __vSphere API 9.1.0.0__.  If true, the upgrade workflow will ignore any pre-check warnings and proceed with the upgrade.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60;, the upgrade workflow will not ignore pre-check warnings and fail the upgrade. It is equivalent to setting the value to false. The workflow adopts a conservative approach of failing the upgrade if missing or &#x60;null&#x60; to solely let the user decide whether to force the upgrade despite the warnings. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

