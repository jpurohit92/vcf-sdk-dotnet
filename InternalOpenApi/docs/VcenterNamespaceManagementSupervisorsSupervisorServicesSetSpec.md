# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesSetSpec
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.SetSpec schema provides a specification required to set a new configuration on a Supervisor Service in a vSphere Supervisor. This schema is applied in entirety, replacing the current specification fully.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | Identifier of the Supervisor Service version which contains the Service definition. This Supervisor Service version must be in the Versions.State#ACTIVATED state.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. | 
**YamlServiceConfig** | **string** | A set of additional configuration parameters to be applied during Service upgrade. These parameters should be formatted as a base64 encoded YAML document. Complex data types with nested properties are supported.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no additional configuration parameters will be applied when upgrading the Supervisor Service in the vSphere Supervisor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

