# Vcenter.Automation.OpenApi.Model.ContentLibraryUsagesInfo
The Content.Library.Usages.Info schema contains information about the usage on a content library.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Usage** | **string** | The identifier of the usage on a content library.  This property was added in __vSphere API 9.1.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Usages&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Usages&#x60;. | 
**ResourceUrn** | **string** | The Uniform Resource Name (URN) of the resource that is using the content library.  This property was added in __vSphere API 9.1.0.0__. | 
**AdditionTime** | **DateTime** | The date and time when the usage got added on the content library.  This property was added in __vSphere API 9.1.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

