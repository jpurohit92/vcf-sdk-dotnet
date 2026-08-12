# Vcenter.ViJson.OpenApi.Model.CnsQueryVolumeRequestType
The parameters of *CnsVolumeManager.CnsQueryVolume*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | [**CnsQueryFilter**](CnsQueryFilter.md) | All container volumes matching the criteria set in the filter will be returned. A maximum of 1000 volume ids can be provided. See *CnsQueryFilter*  | 
**Selection** | [**CnsQuerySelection**](CnsQuerySelection.md) | Selection spec for the query entities to return. This is an optional parameter. All volume fields would be returned if the parameter is not specified. See *CnsQuerySelection*  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

