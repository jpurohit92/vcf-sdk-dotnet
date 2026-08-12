# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementLifecycleContentLibrariesSetSpec
The Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.SetSpec schema contains the specification required to configure vSphere Namespaces with an existing Content Library of Supervisor images.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Library** | **string** | The vSphere Namespaces will be configured with the *Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.SetSpec.library*. *Vcenter.NamespaceManagement.Lifecycle.Content.Libraries.SetSpec.library* must refer to a Content Library in the vSphere inventory.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

