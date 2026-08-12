# Vcenter.ViJson.OpenApi.Model.CnsBackingObjectDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityInMb** | **long** | During creation this field specifies desired container volume capacity in MB.     In case of block and file volumes, when an existing volume is specified then this field will be ignored.    At the time of query, when available, this field will tell the actual capacity of volume that backs the container volume. Else it will be set to -1, to indicate that the capacity of the volume is unknown at the moment. This can happen due to some internal system errors or due to the underlying platform that&#39;s eventually consistent.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

