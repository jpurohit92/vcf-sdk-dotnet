# Vcenter.ViJson.OpenApi.Model.CustomFieldDef

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | A unique ID used to reference this custom field in assignments.  This ID is unique for the lifetime of the field (even across rename operations).  | 
**Name** | **string** | Name of the field.  | 
**Type** | **string** | Type of the field.  | 
**ManagedObjectType** | **string** | Type of object for which the field is valid.  If not specified, the field is valid for all managed objects.  | [optional] 
**FieldDefPrivileges** | [**PrivilegePolicyDef**](PrivilegePolicyDef.md) | The set of privileges to apply on this field definition  | [optional] 
**FieldInstancePrivileges** | [**PrivilegePolicyDef**](PrivilegePolicyDef.md) | The set of privileges to apply on instances of this field  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

