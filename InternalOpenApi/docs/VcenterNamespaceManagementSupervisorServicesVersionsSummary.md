# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesVersionsSummary
The Vcenter.NamespaceManagement.SupervisorServices.Versions.Summary schema contains the basic information about a Supervisor Service version.  This schema was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | **string** | The identifier of the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor_services.Version&#x60;. | 
**DisplayName** | **string** | A human readable name of the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__. | 
**State** | **string** | The current Vcenter.NamespaceManagement.SupervisorServices.Versions.State of the Supervisor Service version.  Possible values:   - &#x60;ACTIVATED&#x60;: The is the default state of a Supervisor Service version upon creation. In this state, all operations on the version should work as normal.   - &#x60;DEACTIVATED&#x60;: The is the deactivated state of a Supervisor Service version. In this state, certain operations on the version are disallowed, for example, the version cannot be created on the vSphere Supervisor clusters.   For more information see: *Vcenter.NamespaceManagement.SupervisorServices.Versions.State*.  This property was added in __vSphere API 7.0.3.0__. | 
**Description** | **string** | A human readable description of the Supervisor Service version.  This property was added in __vSphere API 7.0.3.0__.  If missing or &#x60;null&#x60;, no description is available for the service version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

