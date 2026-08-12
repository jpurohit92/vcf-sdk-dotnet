# Vcenter.Automation.OpenApi.Model.VcenterNamespacesManagementServicesAccessGrantsFilterSpec
The Vcenter.Namespaces.ManagementServices.AccessGrants.FilterSpec schema contains properties used to filter the result when listing the summaries of Access Grants.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManagementServices** | **List&lt;string&gt;** | Identifiers of Management Services.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ManagementService&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ManagementService&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

