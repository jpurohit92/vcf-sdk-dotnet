# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsSupervisorServicesCreateSpec
The Vcenter.NamespaceManagement.Supervisors.SupervisorServices.CreateSpec schema provides a specification required to install a Supervisor Service on a vSphere Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorService** | **string** | Identifier of the Supervisor Service. This Supervisor Service must be in the Versions.State#ACTIVATED state.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. | 
**VarVersion** | **string** | Identifier of the Supervisor Service version which contains the Service definition. This Supervisor Service version must be in the Versions.State#ACTIVATED state.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. | 
**YamlServiceConfig** | **string** | A set of additional configuration parameters to be applied during Service creation. These parameters should be formatted as a base64 encoded YAML document. Complex data types with nested properties are supported.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no additional configuration parameters will be applied when installing the Supervisor Service in the vSphere Supervisor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

