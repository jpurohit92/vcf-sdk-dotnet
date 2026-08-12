# Vcenter.Automation.OpenApi.Model.ContentLibrarySubscriptionsSummary
The Content.Library.Subscriptions.Summary schema contains commonly used information about the subscription.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subscription** | **string** | Identifier of the subscription.  This property was added in __vSphere API 6.7.2__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Subscriptions&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Subscriptions&#x60;. | 
**SubscribedLibrary** | **string** | Identifier of the subscribed library.  This property was added in __vSphere API 6.7.2__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | 
**SubscribedLibraryName** | **string** | Name of the subscribed library.  This property was added in __vSphere API 6.7.2__. | 
**SubscribedLibraryVcenterHostname** | **string** | Hostname of the vCenter instance where the subscribed library exists.  This property was added in __vSphere API 6.7.2__.  This property is unset if the subscribed library is on the same vCenter Server instance as the published library. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

