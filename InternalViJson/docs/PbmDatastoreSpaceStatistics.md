# Vcenter.ViJson.OpenApi.Model.PbmDatastoreSpaceStatistics

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileId** | **string** | Capability profile id.  It is null when the statistics are for the entire datastore.  | [optional] 
**PhysicalTotalInMB** | **long** | Total physical space in MB.  | 
**PhysicalFreeInMB** | **long** | Total physical free space in MB.  | 
**PhysicalUsedInMB** | **long** | Used physical storage space in MB.  | 
**LogicalLimitInMB** | **long** | Logical space limit set by the storage admin in MB.  Omitted if there is no Logical space limit.  | [optional] 
**LogicalFreeInMB** | **long** | Free logical storage space in MB.  | 
**LogicalUsedInMB** | **long** | Used logical storage space in MB.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

