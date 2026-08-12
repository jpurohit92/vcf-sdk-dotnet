# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsManagementServicesUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ManagementServices.UpdateSpec schema provides the specification for updating a Management Service registered with a Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A human-readable description of the Management Service.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, existing description, if present, will be unchanged. | [optional] 
**ManagedBy** | **string** | Human-readable information about the entity responsible for the lifecycle of this Management Service record.    When present, the managedBy value implies that any change to update or delete the Management Service by any principal other than the component referenced by the field may be reverted by the automation component managing it.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, existing value will be kept. | [optional] 
**ManagementAddresses** | **List&lt;string&gt;** | A full list of IP addresses and/or fully-qualified domain names on which the Management Service is running.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, existing value will be kept. | [optional] 
**Ports** | [**List&lt;VcenterNamespaceManagementSupervisorsManagementServicesServicePortUpdateSpec&gt;**](VcenterNamespaceManagementSupervisorsManagementServicesServicePortUpdateSpec.md) | Ports information for the Service. The full list of ports should be provided on update. Each port in the list is expected to be present on each address listed in managementAddresses.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, existing value will be kept. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

