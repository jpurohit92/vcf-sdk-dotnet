# Vcenter.ViJson.OpenApi.Model.PbmQueryAssociatedEntityRequestType
The parameters of *PbmProfileProfileManager.PbmQueryAssociatedEntity*.  This structure may be used only with operations rendered under `/pbm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Profile** | [**PbmProfileId**](PbmProfileId.md) | Profile identifier.  | 
**EntityType** | **string** | If specified, the method returns only those entities which match the type. The &lt;code&gt;entityType&lt;/code&gt; string value must match one of the *PbmObjectType_enum* values. If not specified, the method returns all entities associated with the profile.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

