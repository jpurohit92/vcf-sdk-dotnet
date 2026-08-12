# Vcenter.Automation.OpenApi.Model.ContentLibrarySubscriptionsUpdateSpecVcenter
The Content.Library.Subscriptions.UpdateSpecVcenter schema defines information about the vCenter Server instance where the subscribed library associated with the subscription exists. The Content.Library.Subscriptions.UpdateSpecVcenter schema is only applicable to subscribed library which exists on remote vCenter Server instance.  This schema was added in __vSphere API 6.7.2__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The hostname of the subscribed library&#39;s vCenter Server.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 
**HttpsPort** | **long** | The HTTPS port of the vCenter Server instance where the subscribed library exists.  This property was added in __vSphere API 6.7.2__.  If missing or &#x60;null&#x60;, the value is unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

