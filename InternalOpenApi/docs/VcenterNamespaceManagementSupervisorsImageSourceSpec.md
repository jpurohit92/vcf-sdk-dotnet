# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsImageSourceSpec
The Vcenter.NamespaceManagement.Supervisors.ImageSourceSpec schema contains the specification about the configuration of a Supervisor image.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceType** | **string** | Represents the source of the Supervisor images.  Possible values:   - &#x60;EMBEDDED&#x60;: The Supervisor image is packaged with vCenter Server.   - &#x60;CONTENT_LIBRARY&#x60;: The Supervisor image is hosted in a Content Library configured with vSphere Namespaces.   For more information see: *Vcenter.NamespaceManagement.Supervisors.ImageSourceType*.  This property was added in __vSphere API 9.0.0.0__. | 
**Library** | **string** | If a Supervisor image is hosted in CONTENT_LIBRARY, *Vcenter.NamespaceManagement.Supervisors.ImageSourceSpec.library* represents the identifier of that Content Library.  This property was added in __vSphere API 9.0.0.0__.  This property is optional and it is only relevant when the value of source_type is *Vcenter.NamespaceManagement.Supervisors.ImageSourceType.CONTENT_LIBRARY*.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

