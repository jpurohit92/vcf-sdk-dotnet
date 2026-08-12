# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsUpgradesStatus
The Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.Status schema contains detailed information about the Supervisor when upgraded is in progress.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DesiredVersion** | **string** | Desired version the Supervisor will be upgraded to.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. | 
**Messages** | [**List&lt;VcenterNamespaceManagementSoftwareSupervisorsUpgradesMessage&gt;**](VcenterNamespaceManagementSoftwareSupervisorsUpgradesMessage.md) | Current set of messages associated with the upgrade state.  This property was added in __vSphere API 9.1.0.0__. | 
**Progress** | [**VcenterNamespaceManagementSoftwareSupervisorsUpgradesProgress**](VcenterNamespaceManagementSoftwareSupervisorsUpgradesProgress.md) | Information about upgrade progress.  This property was added in __vSphere API 9.1.0.0__. | 
**Components** | [**List&lt;VcenterNamespaceManagementClustersCondition&gt;**](VcenterNamespaceManagementClustersCondition.md) | Information about control plane components&#39; upgrade status.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the Supervisor pre-checks did not run. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

