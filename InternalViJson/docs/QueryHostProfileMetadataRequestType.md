# Vcenter.ViJson.OpenApi.Model.QueryHostProfileMetadataRequestType
The parameters of *HostProfileManager.QueryHostProfileMetadata*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileName** | **List&lt;string&gt;** | Names of the profiles for which metadata is requested. If not set, the method returns metadata for all the profiles.  | [optional] 
**Profile** | [**ManagedObjectReference**](ManagedObjectReference.md) | Base profile whose context needs to be used during the operation  Refers instance of *Profile*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

