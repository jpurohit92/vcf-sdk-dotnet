# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsManagementServicesInfo
The Vcenter.NamespaceManagement.Supervisors.ManagementServices.Info schema describes the specification of a Management Service registered on a Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ManagementAddresses** | **List&lt;string&gt;** | A list of IP addresses and/or fully-qualified domain names on which the Management Service is running.  This property was added in __vSphere API 9.1.0.0__. | 
**Description** | **string** | A human-readable description of the Management Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the Management Service does not have a description. | [optional] 
**ManagedBy** | **string** | Human-readable information about the entity responsible for the lifecycle of this Management Service record.    When set, the field implies that any change to update or delete the Management Service by any principal other than the component referenced by the field may be reverted by the automation component managing it.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, it implies the Management Service is not created by automation. | [optional] 
**Ports** | [**List&lt;VcenterNamespaceManagementSupervisorsManagementServicesServicePortInfo&gt;**](VcenterNamespaceManagementSupervisorsManagementServicesServicePortInfo.md) | Ports information for the Service. Each port in the list is expected to be present on each address listed in managementAddresses.  This property was added in __vSphere API 9.1.0.0__. | 
**AccessGrantCount** | **long** | Count of Management Service Access Grants referencing this Management Service.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

