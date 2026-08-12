# Vcenter.Automation.OpenApi.Model.ContentLibrarySubscriptionsInfo
The Content.Library.Subscriptions.Info schema contains information about the subscription.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscribedLibrary** | **string** | Identifier of the subscribed library associated with the subscription.  This property was added in __vSphere API 6.7.2__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.Library&#x60;. | 
**SubscribedLibraryName** | **string** | Name of the subscribed library associated with the subscription.  This property was added in __vSphere API 6.7.2__. | 
**SubscribedLibraryLocation** | **string** | Location of the subscribed library relative to the published library.  Possible values:   - &#x60;LOCAL&#x60;: The subscribed library belongs to the same vCenter instance as the published library.   - &#x60;REMOTE&#x60;: The subscribed library belongs to a different vCenter instance than the published library.   For more information see: *Content.Library.Subscriptions.Location*.  This property was added in __vSphere API 6.7.2__. | 
**SubscribedLibraryVcenter** | [**ContentLibrarySubscriptionsVcenterInfo**](ContentLibrarySubscriptionsVcenterInfo.md) | Information about the vCenter Server instance where the subscribed library exists.  This property was added in __vSphere API 6.7.2__.  This property is optional and it is only relevant when the value of subscribed_library_location is *Content.Library.Subscriptions.Location.REMOTE*. | [optional] 
**SubscribedLibraryPlacement** | [**ContentLibrarySubscriptionsPlacementInfo**](ContentLibrarySubscriptionsPlacementInfo.md) | Placement information about the subscribed library&#39;s virtual machine template items.  This property was added in __vSphere API 6.7.2__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

