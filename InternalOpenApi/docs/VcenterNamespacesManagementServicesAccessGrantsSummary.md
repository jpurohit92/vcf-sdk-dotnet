# Vcenter.Automation.OpenApi.Model.VcenterNamespacesManagementServicesAccessGrantsSummary
The Vcenter.Namespaces.ManagementServices.AccessGrants.Summary schema provides the summary for an existing Access Grant.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessGrant** | **string** | Identifier of the Access Grant.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.management_services.AccessGrant&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespaces.management_services.AccessGrant&#x60;. | 
**ManagementService** | **string** | A reference to an existing Management Service.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ManagementService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ManagementService&#x60;. | 
**ManagedBy** | **string** | Information about the entity responsible for the lifecycle of this Access Grant record.    When set, the field implies that any change to update or delete the Access Grant by any principal other than the component referenced by the field may be reverted by the automation component managing it.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, it implies the Access Grant is not managed by automation. | [optional] 
**WorkloadSelector** | [**VcenterNamespacesManagementServicesAccessGrantsWorkloadSelectorSummary**](VcenterNamespacesManagementServicesAccessGrantsWorkloadSelectorSummary.md) | Summary of selection of workloads that are recipients of this grant.  This property was added in __vSphere API 9.1.0.0__. | 
**Enabled** | **bool** | Indicates whether this Access Grant is enabled. The Access Grant is enabled if true, disabled if false. A disabled Access Grant deactivates access for the recipient workloads of the grant to the referenced Management Service.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

