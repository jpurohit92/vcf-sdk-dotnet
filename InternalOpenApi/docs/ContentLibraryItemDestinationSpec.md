# Vcenter.Automation.OpenApi.Model.ContentLibraryItemDestinationSpec
The Content.Library.Item.DestinationSpec schema contains information required to publish the library item to a specific subscription.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Subscription** | **string** | Identifier of the subscription associated with the subscribed library.  This property was added in __vSphere API 6.7.2__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.content.library.Subscriptions&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.content.library.Subscriptions&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

