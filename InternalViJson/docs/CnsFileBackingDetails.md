# Vcenter.ViJson.OpenApi.Model.CnsFileBackingDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityInMb** | **long** | During creation this field specifies desired container volume capacity in MB.     In case of block and file volumes, when an existing volume is specified then this field will be ignored.    At the time of query, when available, this field will tell the actual capacity of volume that backs the container volume. Else it will be set to -1, to indicate that the capacity of the volume is unknown at the moment. This can happen due to some internal system errors or due to the underlying platform that&#39;s eventually consistent.  | [optional] 
**BackingFileId** | **string** | At the time of creation this field would identify the existing file share that should be used to back the container volume.     This field is optional and when not specified, a new file share will be created to back the volume.    When this field is present, capacityInMb and storage policy fields will be ignored.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

