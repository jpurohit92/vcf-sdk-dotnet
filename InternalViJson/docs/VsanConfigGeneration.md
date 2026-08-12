# Vcenter.ViJson.OpenApi.Model.VsanConfigGeneration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VcUuid** | **string** | VC instance UUID to determine which VC generated the config.  | 
**GenNum** | **long** | Generation number, a monotonically increasing number.  | 
**GenTime** | **long** | Generation timestamp, used for human readable consumption, not used to determine which generation is \&quot;newer\&quot;, as timestamps can&#39;t be trusted for this in distributed systems.  The unit of this value is in milli-seconds since the epoch.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

