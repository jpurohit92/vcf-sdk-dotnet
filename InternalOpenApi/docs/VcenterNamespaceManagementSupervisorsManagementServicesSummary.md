# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsManagementServicesSummary
The Vcenter.NamespaceManagement.Supervisors.ManagementServices.Summary schema describes the summarized specification of a Management Service registered on a Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManagementService** | **string** | Identifier of the Management Service.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ManagementService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.ManagementService&#x60;. | 
**ManagedBy** | **string** | Human-readable information about the entity responsible for the lifecycle of this Management Service record.    When set, the field implies that any change to update or delete the Management Service by any principal other than the component referenced by the field may be reverted by the automation component managing it.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, it implies the Management Service is not created by automation. | [optional] 
**AccessGrantCount** | **long** | Count of Management Service Access Grants referencing this Management Service.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

