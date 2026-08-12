# Vcenter.Automation.OpenApi.Model.ContentLibrarySubscriptionsUpdateSpec
The Content.Library.Subscriptions.UpdateSpec schema defines information required to update the subscription.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscribedLibraryVcenter** | [**ContentLibrarySubscriptionsUpdateSpecVcenter**](ContentLibrarySubscriptionsUpdateSpecVcenter.md) | Specification for the subscribed library&#39;s vCenter Server instance.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**SubscribedLibraryPlacement** | [**ContentLibrarySubscriptionsUpdateSpecPlacement**](ContentLibrarySubscriptionsUpdateSpecPlacement.md) | Placement specification for the virtual machine template items of the subscribed library. Updating this information will only affect new or updated items, existing items will not be moved. The entire placement configuration of the subscribed library will replaced by the new specification.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60;, the placement configuration of the subscribed library will be unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

