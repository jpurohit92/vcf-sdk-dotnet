# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCapabilitiesFilterSpec
The Vcenter.NamespaceManagement.Supervisors.Capabilities.FilterSpec schema contains properties to filter Supervisor capabilities.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Capability status for which the Supervisor capabilities should be queried.  Possible values:   - &#x60;SUPPORTED&#x60;: The capability is supported on the Supervisor.   - &#x60;SUPPORTED_NOT_ACTIVATED&#x60;: The capability is supported on the Supervisor but is not activated. The *Vcenter.NamespaceManagement.Supervisors.Capabilities.Capability.messages* field will describe the reason.   - &#x60;UNSUPPORTED&#x60;: The capability is not supported on the Supervisor.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Capabilities.Status*.  This property was added in __vSphere API 9.1.0.0__.  status If set, return the Supervisor capabilities results for the specified status. If missing or &#x60;null&#x60;, the status filter will be ignored. | [optional] 
**Name** | **string** | Capability name for which the Supervisor capabilities should be queried.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, the name filter will be ignored.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Capability&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Capability&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

