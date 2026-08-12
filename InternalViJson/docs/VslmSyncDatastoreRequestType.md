# Vcenter.ViJson.OpenApi.Model.VslmSyncDatastoreRequestType
The parameters of *VslmStorageLifecycleManager.VslmSyncDatastore*.  This structure may be used only with operations rendered under `/vslm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreUrl** | **string** | The datastore URL as specified in *DatastoreInfo.url*  | 
**FullSync** | **bool** | If this is set to true, all information for this datastore will be discarded from the catalog and reloaded from the datastore&#39;s catalog  | 
**FcdId** | [**ID**](ID.md) | If set, this call blocks until fcdId is persisted into db if this fcdId is not found in queue, assume persisted and return  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

