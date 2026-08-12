# Vcenter.Automation.OpenApi.Model.VcenterNamespacesManagementServicesAccessGrantsUpdateSpec
The Vcenter.Namespaces.ManagementServices.AccessGrants.UpdateSpec schema specifies how to update an AccessGrant.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The description of the Access Grant.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the existing value will be unchanged. | [optional] 
**ManagedBy** | **string** | Information about the entity responsible for the lifecycle of this Access Grant record.    When present, the field implies that any change to update or delete the Access Grant by any principal other than the component referenced by the field may be reverted by the automation component managing it.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, existing value will be kept. | [optional] 
**WorkloadSelector** | [**VcenterNamespacesManagementServicesAccessGrantsWorkloadSelectorUpdateSpec**](VcenterNamespacesManagementServicesAccessGrantsWorkloadSelectorUpdateSpec.md) | Selection of workloads to be granted access to the given management service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the existing value will be unchanged. | [optional] 
**Enabled** | **bool** | Set to false to disable the Access Grant, true to re-enable the Access Grant. A disabled Access Grant deactivates access for the recipient workloads of the grant to the referenced Management Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the existing value will be unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

