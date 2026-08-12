# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSoftwareSupervisorsUpgradesFilterSpec
The Vcenter.NamespaceManagement.Software.Supervisors.Upgrades.FilterSpec schema specifies filtering criteria for listing Supervisor upgrade summaries.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supervisors** | **List&lt;string&gt;** | Identifiers of Supervisors to filter the upgrade summaries.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, filtering on a particular Supervisor will not occur.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

