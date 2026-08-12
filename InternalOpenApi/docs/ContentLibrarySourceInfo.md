# Vcenter.Automation.OpenApi.Model.ContentLibrarySourceInfo
The Content.Library.SourceInfo schema contains information about the source published library of a subscribed library.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceLibrary** | **string** | Identifier of the published library.  This property was added in __vSphere API 6.7.2__.  This property must be provided for the &#x60;create&#x60; operation. It will always be present in the response of the &#x60;get&#x60; or &#x60;list&#x60; operations. It is optional for the &#x60;update&#x60; operation.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | [optional] 
**Subscription** | **string** | Identifier of the subscription associated with the subscribed library.  This property was added in __vSphere API 6.7.2__.  This property must be provided for the &#x60;create&#x60; operation. It will always be present in the response of the &#x60;get&#x60; or &#x60;list&#x60; operations. It is optional for the &#x60;update&#x60; operation.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Subscriptions&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Subscriptions&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

