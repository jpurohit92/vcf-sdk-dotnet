# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCapabilitiesListResult
The Vcenter.NamespaceManagement.Supervisors.Capabilities.ListResult schema contains information about the capabilities of the Supervisor.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Supervisor** | **string** | Identifier for the Supervisor.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Supervisor&#x60;. | 
**VarVersion** | **string** | Identifier for the Supervisor version.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;SupervisorVersion&#x60;. | 
**Capabilities** | [**List&lt;VcenterNamespaceManagementSupervisorsCapabilitiesCapability&gt;**](VcenterNamespaceManagementSupervisorsCapabilitiesCapability.md) | List of Supervisor capabilities.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

