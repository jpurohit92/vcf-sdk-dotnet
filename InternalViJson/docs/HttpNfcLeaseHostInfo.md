# Vcenter.ViJson.OpenApi.Model.HttpNfcLeaseHostInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The host url will be of the form      https://hostname/nfc/ticket id/ The url can be used for both POST requests to a single device and for multi-POST requests to multiple devices. A single-POST URL is formed by adding the target id to the hostUrl:      https://hostname/nfc/ticket id/target id a multi-POST URL looks like      https://hostname/nfc/ticket id/multi?targets&#x3D;id1,id2,id3,...  | 
**SslThumbprint** | **string** | SSL thumbprint for the host the URL refers to.  Empty if no SSL thumbprint is available or needed.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

