# Vcenter.ViJson.OpenApi.Model.PbmQuerySpaceStatsForStorageContainerRequestType
The parameters of *PbmProfileProfileManager.PbmQuerySpaceStatsForStorageContainer*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**PbmServerObjectRef**](PbmServerObjectRef.md) | Entity for which space statistics are being requested i.e datastore.  | 
**CapabilityProfileId** | [**List&lt;PbmProfileId&gt;**](PbmProfileId.md) | \\- capability profile Ids. If omitted, the statistics for the container as a whole would be returned.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

