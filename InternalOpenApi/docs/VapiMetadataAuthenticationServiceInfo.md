# Vcenter.Automation.OpenApi.Model.VapiMetadataAuthenticationServiceInfo
The Vapi.Metadata.Authentication.ServiceInfo schema contains authentication information of a service element.    For an explanation of authentication information contained within service elements, see *Vapi.Metadata.Authentication.Service*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Schemes** | [**List&lt;VapiMetadataAuthenticationAuthenticationInfo&gt;**](VapiMetadataAuthenticationAuthenticationInfo.md) | List of authentication schemes to be used for all the operation elements contained in this service element. The authentication scheme specified on the package element corresponding to this service element is ignored. | 
**Operations** | [**Dictionary&lt;string, VapiMetadataAuthenticationOperationInfo&gt;**](VapiMetadataAuthenticationOperationInfo.md) | Information about all operation elements contained in this service element that contain authentication information. The key in the map is the identifier of the operation element and the value in the map is the authentication information for the operation element.    For an explanation of containment of authentication information within operation elements, see *Vapi.Metadata.Authentication.Service.Operation*.  When clients pass a value of this schema as a parameter, the key in the property map must be an identifier for the resource type: &#x60;com.vmware.vapi.operation&#x60;. When operations return a value of this schema as a response, the key in the property map will be an identifier for the resource type: &#x60;com.vmware.vapi.operation&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

