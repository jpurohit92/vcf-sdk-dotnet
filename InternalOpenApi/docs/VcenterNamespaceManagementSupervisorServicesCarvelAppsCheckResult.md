# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesCarvelAppsCheckResult
The Vcenter.NamespaceManagement.SupervisorServices.CarvelAppsCheckResult schema contains the information of a Supervisor Service version that is retrieved from the content in Carvel application package format as a result of the *POST /vcenter/namespace-management/supervisor-services?action=checkContent* operation.  This schema was added in __vSphere API 8.0.0.1__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SupervisorService** | **string** | The identifier of the Supervisor Service.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.SupervisorService&#x60;. | 
**VarVersion** | **string** | The identifier of the Supervisor Service version.  This property was added in __vSphere API 8.0.0.1__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. | 
**DisplayName** | **string** | A human readable name of the Supervisor Service version.  This property was added in __vSphere API 8.0.0.1__. | 
**Description** | **string** | A human readable description of the Supervisor Service version.  This property was added in __vSphere API 8.0.0.1__.  If missing or &#x60;null&#x60;, no description is available for the Supervisor Service version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

