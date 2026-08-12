# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsCapabilitiesCapability
The Vcenter.NamespaceManagement.Supervisors.Capabilities.Capability schema represents a Supervisor feature and its specification.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Supervisor feature.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Capability&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.namespace_management.supervisor.Capability&#x60;. | 
**Status** | **string** | Represents the activation state of the capability.  Possible values:   - &#x60;SUPPORTED&#x60;: The capability is supported on the Supervisor.   - &#x60;SUPPORTED_NOT_ACTIVATED&#x60;: The capability is supported on the Supervisor but is not activated. The *Vcenter.NamespaceManagement.Supervisors.Capabilities.Capability.messages* field will describe the reason.   - &#x60;UNSUPPORTED&#x60;: The capability is not supported on the Supervisor.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Capabilities.Status*.  This property was added in __vSphere API 9.1.0.0__. | 
**Description** | **string** | A description about the Supervisor capability.  This property was added in __vSphere API 9.1.0.0__. | 
**Messages** | [**List&lt;VapiStdLocalizableMessage&gt;**](VapiStdLocalizableMessage.md) | Messages describes why a capability status is *Vcenter.NamespaceManagement.Supervisors.Capabilities.Status.SUPPORTED_NOT_ACTIVATED*.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, capability is either *Vcenter.NamespaceManagement.Supervisors.Capabilities.Status.SUPPORTED* or *Vcenter.NamespaceManagement.Supervisors.Capabilities.Status.UNSUPPORTED*. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

