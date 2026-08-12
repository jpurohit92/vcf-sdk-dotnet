# Vcenter.ViJson.OpenApi.Model.VasaProviderStatusEnum
The operational state of VASA Provider.  Possible values: - `online`: VASA Provider is operating correctly. - `offline`: VASA Provider is not responding, e.g.      communication error due to temporary   network outage. SMS keeps polling the provider in this state. - `syncError`: VASA Provider is connected, but sync operation failed. - `unknown`:       Deprecated as of SMS API 4.0, this status is deprecated.      VASA Provider is unreachable. - `connected`: VASA Provider is connected, but has not triggered sync operation. - `disconnected`: VASA Provider is disconnected, e.g.      failed to establish a valid   SSL connection to the provider. SMS stops communication with the   provider in this state. The user can reconnect to the provider by invoking   *VasaProvider.VasaProviderReconnect_Task*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

