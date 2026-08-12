# Vcenter.ViJson.OpenApi.Model.VsanWhatIfEvacDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | Indicates whether evacuation of specified entity could be done.  | [optional] 
**BytesToSync** | **long** | Indicates how many bytes need to be synced to satisfy the evacuation of specified entity.  | [optional] 
**InaccessibleObjects** | **List&lt;string&gt;** | Indicates objects which would be inaccessible due to the evacuation of specified entity.  | [optional] 
**IncompliantObjects** | **List&lt;string&gt;** | Indicates objects which would be non-compliant due to the evacuation of specified entity.  | [optional] 
**ExtraSpaceNeeded** | **long** | Indicates how many additional storage space is needed for the evacuation of specified entity.  | [optional] 
**FailedDueToInaccessibleObjects** | **bool** | Indicates whether evacuation of specified entity would fail due to inaccessible objects.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

