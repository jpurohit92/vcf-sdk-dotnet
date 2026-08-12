# Vcenter.ViJson.OpenApi.Model.VsanObjectQuerySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uuid** | **string** | vSAN object UUID.  | 
**SpbmProfileGenerationId** | **string** | Current storage profile generation id for the profile used by vSAN object, it should be retrieved from SPBM service.  If vSAN object doesn&#39;t use a storage profile in SPBM service, the generation id should be null. It is used to compare with the generation id of the profile at the time the profile was applied the to vSAN object, if they are not the same, it means the profile used by the vSAN object is out of date.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

