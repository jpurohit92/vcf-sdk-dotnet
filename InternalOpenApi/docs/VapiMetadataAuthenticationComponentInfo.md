# Vcenter.Automation.OpenApi.Model.VapiMetadataAuthenticationComponentInfo
The Vapi.Metadata.Authentication.ComponentInfo schema contains authentication information of a component element.    For an explanation of authentication information contained within component elements, see *Vapi.Metadata.Authentication.Component*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Packages** | [**Dictionary&lt;string, VapiMetadataAuthenticationPackageInfo&gt;**](VapiMetadataAuthenticationPackageInfo.md) | Authentication information of all the package elements. The key in the map is the identifier of the package element and the value in the map is the authentication information for the package element.    For an explanation of authentication information containment within package elements, see *Vapi.Metadata.Authentication.Package*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vapi.package&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vapi.package&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

