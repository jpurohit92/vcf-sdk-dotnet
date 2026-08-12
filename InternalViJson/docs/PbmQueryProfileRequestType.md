# Vcenter.ViJson.OpenApi.Model.PbmQueryProfileRequestType
The parameters of *PbmProfileProfileManager.PbmQueryProfile*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceType** | [**PbmProfileResourceType**](PbmProfileResourceType.md) | Type of resource. You can specify only STORAGE.  | 
**ProfileCategory** | **string** | Profile category. The string value must correspond to one of the *PbmProfileCategoryEnum_enum* values. If you do not specify a profile category, the method returns profiles in all categories.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

