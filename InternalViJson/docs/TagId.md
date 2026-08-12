# Vcenter.ViJson.OpenApi.Model.TagId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NameId** | [**TagIdNameId**](TagIdNameId.md) | Information about the name of the tag represented by this TagId.  If this field is specified in addition to *TagId.uuid*, then both *TagId.uuid* and nameId must belong to the same vSphere tag. If this field is left unset, then *TagId.uuid* must be specified.  | [optional] 
**Uuid** | **string** | The UUID of the vSphere tag represented by this TagId.  If this field is specified in addition to *TagId.nameId*, then both uuid and *TagId.nameId* must belong to the same vSphere tag. If this field is left unset, then *TagId.nameId* must be specified.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

