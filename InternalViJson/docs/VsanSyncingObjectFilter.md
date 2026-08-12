# Vcenter.ViJson.OpenApi.Model.VsanSyncingObjectFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResyncType** | **string** | Return syncing objects based on resync type specified by user.  User specifies one of the values defined in *VsanSyncReason_enum*  See also *VsanSyncReason_enum*.  | [optional] 
**ResyncStatus** | **string** | Return syncing objects based on resync status specified by user.  User specifies one of the values defined in *VsanSyncStatus_enum*  See also *VsanSyncStatus_enum*.  | [optional] 
**NumberOfObjects** | **long** | Number of actively resyncing objects for which component level details are required.  Default value will be 0, none objects returned.  | [optional] 
**Offset** | **long** | Indicates the number of objects to be skipped when for resyncing object to be returned.  Objects to return is calculated based on start and number of objects. 0 if not specified. Value less than 0 is illegal.  | [optional] 
**IncludeDedupObject** | **bool** | Whether the query result includes the dedup store objects.  If do not set it to true, dedup store objects are not included by default.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

