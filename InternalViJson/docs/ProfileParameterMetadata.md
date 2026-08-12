# Vcenter.ViJson.OpenApi.Model.ProfileParameterMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ExtendedElementDescription**](ExtendedElementDescription.md) | Identifier for the parameter.  | 
**Type** | **string** | Type of the parameter.  | 
**Optional** | **bool** | Whether the parameter is optional.  | 
**DefaultValue** | [**Any**](Any.md) | Default value that can be used for the parameter.  | [optional] 
**Hidden** | **bool** | Whether the parameter will not be displayed in UI.  | [optional] 
**SecuritySensitive** | **bool** | Whether the parameter is security sensitive.  | [optional] 
**ReadOnly** | **bool** | Indicates that the parameter value is read-only.  | [optional] 
**ParameterRelations** | [**List&lt;ProfileParameterMetadataParameterRelationMetadata&gt;**](ProfileParameterMetadataParameterRelationMetadata.md) | Relations with other profile or parameters.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

