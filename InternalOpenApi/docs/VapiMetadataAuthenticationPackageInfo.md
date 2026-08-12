# Vcenter.Automation.OpenApi.Model.VapiMetadataAuthenticationPackageInfo
The Vapi.Metadata.Authentication.PackageInfo schema contains authentication information of a package element.    For an explanation of authentication information contained within package elements, see *Vapi.Metadata.Authentication.Package*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schemes** | [**List&lt;VapiMetadataAuthenticationAuthenticationInfo&gt;**](VapiMetadataAuthenticationAuthenticationInfo.md) | List of authentication schemes to be used for all the operation elements contained in this package element. If a particular service or operation element has no explicit authentications defined in the authentication defintion file, these authentication schemes are used for authenticating the user. | 
**Services** | [**Dictionary&lt;string, VapiMetadataAuthenticationServiceInfo&gt;**](VapiMetadataAuthenticationServiceInfo.md) | Information about all service elements contained in this package element that contain authentication information. The key in the map is the identifier of the service element and the value in the map is the authentication information for the service element.    For an explanation of authentication information containment within service elements, see *Vapi.Metadata.Authentication.Service*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vapi.service&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vapi.service&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

