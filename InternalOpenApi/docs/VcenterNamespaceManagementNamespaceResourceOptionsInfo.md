# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNamespaceResourceOptionsInfo
The Vcenter.NamespaceManagement.NamespaceResourceOptions.Info schema contains the information about the objects used to set and update resource quota keys on a namespace.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateResourceQuotaType** | **string** | Identifier of the schema used to set resource quotas on the namespace. See *POST /vcenter/namespaces/instances* and *PUT /vcenter/namespaces/instances/{namespace}*.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | 
**UpdateResourceQuotaType** | **string** | Identifier of the schema used to update resource quotas on the namespace. See *PATCH /vcenter/namespaces/instances/{namespace}*.  This property was added in __vSphere API 7.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vapi.structure&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

